using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpaceShipMoving : MonoBehaviour
{
    public float _speedRotate = 1f;
    public float _shipSpeed = 10f;

    void Start()
    {
        
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.D))
        {
            this.transform.Rotate(0, 0, -_speedRotate);
        }
        else if (Input.GetKey(KeyCode.A))
        {
            this.transform.Rotate(0, 0, _speedRotate);
        }
        else if (Input.GetKey(KeyCode.W))
        {
            this.transform.Translate(0, Time.deltaTime * _shipSpeed, 0);
        }
    }
}
