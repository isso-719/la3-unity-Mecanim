using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeAnimatorController : MonoBehaviour
{
    Animator animator;

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKey(KeyCode.A))
        {
            animator.SetInteger("trigger", 1);
        } else if (Input.GetKey(KeyCode.S))
        {
            animator.SetInteger("trigger", 2);
        } else
        {
            animator.SetInteger("trigger", 0);
        }
    }
}
