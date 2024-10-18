using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAnimationAction : AIAction
    //clase abstracta template que pueden usar los hijos
{
    public override void PerformAction() { }

    public override void OnEnterState()
    {
        base.OnEnterState();
        GetComponentInChildren<Animator>().SetBool("IsFollowing", false);

    }
}
