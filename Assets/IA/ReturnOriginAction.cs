using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReturnOriginAction : AIAction
{
    public Vector3 originPos;
    public float speed = 1.0f;
    public override void PerformAction()
    {
        float step = speed * Time.deltaTime; //calculate distance to move
        transform.position = Vector3.MoveTowards(transform.position, originPos, step);
        transform.LookAt(originPos);
    }
}
