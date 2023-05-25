using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    
    private Animator anim;
    
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    void Update()
    {
        walk();
    }
    void walk()
    {
        if (Input.GetKey(KeyCode.W))
        {
            anim.SetBool("isMoving", true);
            anim.SetFloat("Axis Y", 1);
        }
        
        else if (Input.GetKey(KeyCode.S))
        {
            anim.SetBool("isMoving", true);
            anim.SetFloat("Axis Y", -1);
        }
        else if (Input.GetKey(KeyCode.D))
        {
            anim.SetBool("isMoving", true);
            anim.SetFloat("Axis X", 1);
        }
        else if (Input.GetKey(KeyCode.A))
        {
            anim.SetBool("isMoving", true);
            anim.SetFloat("Axis X", -1);
        }
        else
        {
            anim.SetBool("isMoving", false);
            anim.SetFloat("Axis X", 0);
            anim.SetFloat("Axis Y", 0);
        }
    }
}
