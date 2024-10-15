using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimplePlayerMovement : MonoBehaviour
{
    public float speed = 1.0f;

    void Update()
    {
        Vector3 pos = this.transform.position;
        float step =speed*Time.deltaTime;
        float x = pos.x += (Input.GetAxis("Horizontal") * step);
        float z = pos.z += (Input.GetAxis("Vertical") * step);
        this.transform.position = new Vector3(x, pos.y, z);

    }
}
