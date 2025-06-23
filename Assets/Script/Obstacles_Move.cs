using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacles_Move : MonoBehaviour
{
    public GameObject[] obstaclesArray;
    public Transform[] obstacleTransformArray;
    public GameObject moveGameObject;
    public int obstacleCount;
    public int obstacleIndex;
    public int moveIndex;
    /*public GameObject parentOBJ;*/
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("Obstaclesss", 1f, 2f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void Obstaclesss()
    {
        obstacleCount= Random.Range(0, obstaclesArray.Length);
        obstacleIndex=Random.Range(0, obstacleTransformArray.Length);

       Instantiate(obstaclesArray[obstacleCount], obstacleTransformArray[obstacleIndex].position, obstaclesArray[obstacleCount].transform.rotation);
        // (transform.Translate(Vector3.back * moveIndex * Time.deltaTime);
       // obstaclesArray[obstacleCount].transform.parent = parentOBJ.transform;
    }
}
