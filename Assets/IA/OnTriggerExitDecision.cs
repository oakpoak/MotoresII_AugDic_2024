using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class OnTriggerExitDecision : AIDecision
{
    private bool hasPlayerEnter;
    public override bool Decide()
    {
        return hasPlayerEnter;
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag== "Player")
        {
            hasPlayerEnter = false;
            

        }
    }
    public override void OnExitState()
    {
        base.OnExitState();
        hasPlayerEnter = true;
    }
}
