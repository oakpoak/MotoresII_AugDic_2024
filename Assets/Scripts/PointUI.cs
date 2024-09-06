using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class PointUI : MonoBehaviour
{
    //VARIABLES
    public TMP_Text scoreText;

    void Update()
    {
        scoreText.text = PointManager.instance.GetScore().ToString();
    }
    public void OnClick_AddPoints()
    {
        //Desactivar el collider
        //Activar sfx
        //Desactivar render mesh
        //etc
        PointManager.instance.AddPoints(10);
    }
    public void OnClick_SubstractPoints()
    {
        PointManager.instance.RemovePoints(5);

    }
    public void OnClick_WinAnahuacEvent()
}
