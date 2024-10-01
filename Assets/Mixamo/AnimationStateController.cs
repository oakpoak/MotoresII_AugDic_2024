using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationStateController : MonoBehaviour
{
    private Animator animator;
    private float velocity;
    private int velocityHash;

    public float acceleration = 0.1f;
    public float desceleration = 0.5f;

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        velocityHash = Animator.StringToHash("Velocity");
    }

    // Update is called once per frame
    void Update()
    {
        bool forwardPressed = Input.GetKey(KeyCode.W);
        bool runPressed = Input.GetKey(KeyCode.LeftShift);

        //TODO: Modificar valor de velocity;

        if (forwardPressed && velocity<1.0f)
        {
            velocity += Time.deltaTime * acceleration;
        }



        if (!forwardPressed && velocity>0.0f)
        {
            velocity -= Time.deltaTime * desceleration;
        }

        if (!forwardPressed && velocity <0.0f)
        {
            velocity = 0.0f;
        }

        animator.SetFloat(velocityHash , velocity);
    }
}
