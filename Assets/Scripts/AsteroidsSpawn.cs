using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class AsteroidsSpawn : MonoBehaviour
{
    public GameObject[] astrsType;
    public List<GameObject> massAstrs = new List<GameObject>();
    public GameObject spawnObject;
    public int Count = 2;

    private GameObject astr;
    private int astrCount = 2;

    void Awake()
    {
        massAstrs.Add(astrsType[0]);
        massAstrs[0] = Instantiate(astrsType[0], new Vector3(Random.Range(-9.2f, 9.2f), Random.Range(-5.45f, 5.45f), 0), Quaternion.identity) as GameObject;
        massAstrs.Add(astrsType[0]);
        massAstrs[1] = Instantiate(astrsType[0], new Vector3(Random.Range(-9.2f, 9.2f), Random.Range(-5.45f, 5.45f), 0), Quaternion.identity) as GameObject;
    }

    void FixedUpdate()
    {
        astr = GameObject.FindWithTag("astrBig");
        if (astr == null)
        {
            astrCount++;
            for (int i = 0; i < astrCount; i++)
            {
                massAstrs[i] = Instantiate(astrsType[0], new Vector3(Random.Range(-9.2f, 9.2f), Random.Range(-5.45f, 5.45f), 0), Quaternion.identity) as GameObject;
            }
        }
    }


}
    