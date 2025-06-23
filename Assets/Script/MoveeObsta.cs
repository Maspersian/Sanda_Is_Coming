using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveeObsta : MonoBehaviour
{
    //public GameObject gift;
    public int movefree;
    // Start is called before the first frame update
    void Start()
    {
       /* InvokeRepeating("malar", 1f, 3f);*/
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.back * movefree * Time.deltaTime);
    }
    /*void malar()
    {
      
    }*/
}
