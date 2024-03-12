using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Kart : MonoBehaviour
{
    Camera cam;
    Rigidbody rigid;
    [SerializeField] float speed;
    [SerializeField] float rotateSpeed = 2;


    private void Awake()
    {
        rigid = GetComponent<Rigidbody>();
    }

    // Start is called before the first frame update
    void Start()
    {
        cam = Camera.main;
    }

    // Update is called once per frame
    void Update()
    {
        checkGravity();
        moving();
        Debug.Log(rigid.velocity);
    }

    private void checkGravity()
    {

    }

    private void moving()
    {
        if (Input.GetKey(KeyCode.UpArrow))
        {
            //transform.position = transform.forward;
            //rigid.velocity = transform.forward;

            rigid.AddForce(transform.forward * speed);//천천히 앞으로 움직임
        }

        if (Input.GetKey(KeyCode.DownArrow))
        {
            rigid.AddForce(-transform.forward * (speed - 1f));
        }

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            //rigid.rotation = Quaternion.Euler(0,10,0);
            rigid.rotation *= Quaternion.Euler(0, -0.3f, 0);
        }

        if (Input.GetKey(KeyCode.RightArrow))
        {
            rigid.rotation *= Quaternion.Euler(0, 0.3f, 0);
        }
    }
}
