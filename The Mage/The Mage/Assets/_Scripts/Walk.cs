using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Walk : MonoBehaviour
{
    private Animator anim;
    private float flagX;
    private float flagY;
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    void Update()
    {
        if(Input.GetKey(KeyCode.W))
        {
            anim.SetBool("isMoving", true);
            flagY = 1;
            flagX = 0;
            anim.SetFloat("Y", 1);
        }
        else if(Input.GetKey(KeyCode.S))
        {
            anim.SetBool("isMoving", true);
            flagY = -1;
            flagX = 0;
            anim.SetFloat("Y", -1);
        }
        else if(Input.GetKey(KeyCode.D))
        {
            anim.SetBool("isMoving", true);
            flagX = 1;
            flagY = 0;
            anim.SetFloat("X", 1);
        }
        else if(Input.GetKey(KeyCode.A))
        {
            anim.SetBool("isMoving", true);
            flagX = -1;
            flagY = 0;
            anim.SetFloat("X", -1);
        }
        else
        {
            anim.SetBool("isMoving", false);
            anim.SetFloat("idleX", flagX);
            anim.SetFloat("idleY", flagY);
            anim.SetFloat("X", 0);
            anim.SetFloat("Y", 0);
        }
    }
}
