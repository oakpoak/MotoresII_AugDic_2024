using System.Collections;
using System.Collections.Generic;
using UnityEditor.Rendering;
using UnityEngine;

public class FollowTargetAction : AIAction
{
    public float speed;
    public override void PerformAction()
    {
       if(_brain.Target != null)
        {
            float step = speed *Time.deltaTime; //calculate.distance to move
            transform.position =Vector3.MoveTowards(transform.position, _brain.Target.position, step);
            transform.LookAt(_brain.Target.position);
        }
    }
}
