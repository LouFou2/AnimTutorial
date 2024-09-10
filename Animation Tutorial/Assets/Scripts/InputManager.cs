using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputManager : MonoBehaviour
{
    private Animator animator;
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    void Update()
    {
        bool isSpinning = animator.GetBool("Spin");

        if (Input.GetKeyDown(KeyCode.Space)) 
        {
            isSpinning = !isSpinning; // toggles opposite of current bool
            animator.SetBool("Spin", isSpinning);
        }
    }
}
