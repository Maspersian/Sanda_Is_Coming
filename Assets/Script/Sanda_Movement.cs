using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//using static UnityEditor.PlayerSettings;

public class Sanda_Movement : MonoBehaviour
{
    Vector3 pos;
    public float speed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        pos = transform.position;
        pos.x += Input.GetAxis("Horizontal") * speed* Time.deltaTime;
        pos.x = Mathf.Clamp(pos.x, 7f, 13f);
        transform.position = pos;
    }
}
