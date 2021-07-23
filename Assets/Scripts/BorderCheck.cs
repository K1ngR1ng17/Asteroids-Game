using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BorderCheck : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x < -9.2)
            transform.position = new Vector3(transform.position.x + 18.4f, transform.position.y, transform.position.z);
        else if (transform.position.x > 9.2)
            transform.position = new Vector3(transform.position.x - 18.4f, transform.position.y, transform.position.z);
        else if (transform.position.y < -5.45)
            transform.position = new Vector3(transform.position.x, transform.position.y + 10.9f, transform.position.z);
        else if (transform.position.y > 5.45)
            transform.position = new Vector3(transform.position.x, transform.position.y - 10.9f, transform.position.z);
    }
}
