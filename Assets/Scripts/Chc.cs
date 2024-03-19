using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chc : MonoBehaviour
{
    private CharacterController Chcontroller;
    [SerializeField] float speed;



    private void Awake()
    {
        Chcontroller = GetComponent<CharacterController>();
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
        Input.GetAxisRaw("Vertical");
        Input.GetAxisRaw("Horizontal");
    }

}
