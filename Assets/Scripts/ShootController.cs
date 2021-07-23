using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootController : MonoBehaviour
{
    public GameObject shells;
    public Transform spawnPoint;

    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            GameObject shell = Instantiate(shells, spawnPoint.position, spawnPoint.rotation);           
        }
        
    }

}
