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
    public void Inicialization()
    {
    hasPlayerEnter = false; 
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            hasPlayerEnter = true;
            _brain.Target = other.transform; 
        }
    }
    public override void OnEnterState()
    {
        base.OnEnterState();
        hasPlayerEnter = false;
    }

}
