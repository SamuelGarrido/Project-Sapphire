using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class animationController : MonoBehaviour
{
    public Animator Anim;

    void Start(){
        Anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update(){
        if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.D)){
            Anim.SetBool("isWalking", true);
        }
        else if (Input.GetButtonDown("Jump")){
            Anim.SetBool("isJumping", true);
        }
        else{
            Anim.SetBool("isWalking", false);
            Anim.SetBool("isJumping", false);
        }


    }
}
