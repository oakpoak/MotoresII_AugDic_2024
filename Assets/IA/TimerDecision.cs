using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimerDecision : AIDecision
{
    public float maxTime;
    public override bool Decide()
    {
       /* if(_brain.TimeInThisState >= maxTime)
        {
            return true;
        }
        else
        {
            return false;
        }*/
        return _brain.TimeInThisState >= maxTime;
    }


}
