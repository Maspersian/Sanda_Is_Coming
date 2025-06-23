using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementTera : MonoBehaviour
{
    public GameObject terrainMove;
    public GameObject terrainMove2;
    public float smooth;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        terrainMove.transform.Translate(terrainMove2. transform.position*smooth*Time.deltaTime);
    }
}
