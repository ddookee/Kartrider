using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Kart : MonoBehaviour
{
    Rigidbody rigid;
    [SerializeField] float speed;
    Vector3 movedir = new Vector3(0, 0, 0);


    private void Awake()
    {
        rigid = GetComponent<Rigidbody>();
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        moving();
    }

    private void moving()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            movedir += new Vector3(0, 0, 10) * speed;
        }

        if (Input.GetKeyDown(KeyCode.DownArrow))
        {

        }

        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {

        }

        if (Input.GetKeyDown(KeyCode.RightArrow))
        {

        }
    }
}
