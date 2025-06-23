using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackwardMovement : MonoBehaviour
{
    public GameObject terrainDup;
    public Transform terrainInstanPoa;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("Insta", 0.001f, 8f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void Insta()
    {
        Instantiate(terrainDup, terrainInstanPoa.position,Quaternion.identity);
    }
}
