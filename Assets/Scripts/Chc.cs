using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chc : MonoBehaviour
{
    private CharacterController Chcontroller;
    [SerializeField] float speed;
    [SerializeField] float MaxAngle;
    private Vector3 moveDir;



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
        float motor = Input.GetAxisRaw("Vertical") * speed;
        float angle = Input.GetAxisRaw("Horizontal") * MaxAngle;
        moveDir = new Vector3(angle, 0f, motor);
        Chcontroller.Move(moveDir);
    }

}
