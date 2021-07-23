using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class astrMoving : MonoBehaviour
{
    public float astrSpeed;

    private float x, y;
    void Start()
    {
        x = Random.Range(-9.2f, 9.2f);
        y = Random.Range(-5.45f, 5.45f);
    }
    void Update()
    {
        this.transform.Translate(new Vector3(x, y, 0) * astrSpeed * Time.deltaTime);
    }
}
