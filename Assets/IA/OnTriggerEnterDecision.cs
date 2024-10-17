using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnTriggerEnterDecision : AIDecision
{
    private bool hasPlayerEnter;
    public override bool Decide()
    {
        return hasPlayerEnter;

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            _brain.Target = other.transform;
            hasPlayerEnter = true;
        }
    }
    public override void OnEnterState()
    {
        base.OnEnterState();
        hasPlayerEnter = false;
    }

}
