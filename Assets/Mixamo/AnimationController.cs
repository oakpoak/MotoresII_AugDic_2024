using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationController : MonoBehaviour
{
    private Animator animator;
    private int IsWalkingHash;
    private int IsRunningHash;
    void Start()
    {
        animator = this.GetComponent<Animator>();
        IsWalkingHash = Animator.StringToHash("IsWalking");
        IsRunningHash = Animator.StringToHash("IsRunning");
    }

    // Update is called once per frame
    void Update()
    {
        bool IsWalking = animator.GetBool(IsWalkingHash);
        bool forwardPressed = Input.GetKey(KeyCode.W);

        bool IsRunning = animator.GetBool(IsRunningHash);
        bool runPressed = Input.GetKey(KeyCode.LeftShift);
        /*if (Input.GetKey(KeyCode.W))
         {
             animator.SetBool("IsWalking", true);
         }
         if (!Input.GetKey(KeyCode.W))
         {
             animator.SetBool("IsWalking", false);
         }*/
        if (forwardPressed && !IsWalking)
        {
            animator.SetBool(IsWalkingHash, true);
        }
        if (!forwardPressed && IsWalking)
        {
            animator.SetBool(IsWalkingHash, false);
        }

        if ((forwardPressed && runPressed) && !IsRunning) 
        {
            animator.SetBool(IsRunningHash, true);
        }
        if ((!forwardPressed || !runPressed) && IsRunning)
        {
            animator.SetBool(IsRunningHash, false);
        }
    }
}
