using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Chc : MonoBehaviour
{
    [SerializeField] float Maxtorque;
    [SerializeField] float MaxAngle;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float motor = Maxtorque * Input.GetAxisRaw("Vertical");
        float angle = MaxAngle * Input.GetAxisRaw("Horizontal");
    }
}
