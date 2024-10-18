using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DistanceDecision : AIDecision
{
    public Vector3 originPos;
    public override bool Decide()
    {
        return Vector3.Distance(transform.position, originPos) < 0.001f;
    }
}
