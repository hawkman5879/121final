using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Controller : MonoBehaviour
{
    private Animator anim;
    private Rigidbody rB;
    public float speed = 1f;


    void Start()
    {
        anim = gameObject.GetComponent<Animator>();
        rB = GetComponent<Rigidbody>();
        anim.Play("Idle");
        

    }
    void Update()
    {
        Move();
    }
    public void Move()
    {
        if ( Input.GetKey("w"))
        {
            transform.Translate(Vector3.forward * Time.deltaTime * speed);
        }
        if (Input.GetKey("s"))
        {
            //anim.Play("run");
            transform.Translate(Vector3.back * Time.deltaTime * speed);
        }
        if (Input.GetKey("a"))
        {
            //anim.Play("run");
            transform.Translate(Vector3.left * Time.deltaTime * speed);
        }
        if (Input.GetKey("d"))
        {
            //anim.Play("run");
            transform.Translate(Vector3.right * Time.deltaTime * speed);
        }
    }
}
