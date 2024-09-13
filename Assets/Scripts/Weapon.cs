using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;


public class Weapon : MonoBehaviour
{
    public GameObject bulletPrefab;
    public Transform spawnPoint;
    // Start is called before the first frame update
   
    private Color GetRandomColor()
    {
        // Generar un color aleatorio
        return new Color(Random.value, Random.value, Random.value);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            GameObject newBullet= Instantiate(bulletPrefab);
            newBullet.transform.position = spawnPoint.position;
            newBullet.transform.rotation = spawnPoint.rotation;
            newBullet.GetComponent<Rigidbody>().AddForce(spawnPoint.transform.forward*100.0f);
            StartCoroutine(CR_WaitColor(newBullet));
            StartCoroutine(CR_Destroy(newBullet));
        }


    }

    IEnumerator CR_WaitColor(GameObject newBullet)
    {
        while (true)
        {
            newBullet.GetComponent<MeshRenderer>().material.color = GetRandomColor();
            yield return new WaitForSeconds(0.5f);
        }
    }

    IEnumerator CR_Destroy(GameObject newBullet)
    {
        yield return new WaitForSeconds(4.0f);
        //Destroy(newBullet);
        PoolManager.Instance.ReturnObjectToPool(newBullet);
    }


        
    
}
