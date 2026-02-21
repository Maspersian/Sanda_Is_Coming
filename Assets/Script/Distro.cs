using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Distro : MonoBehaviour
{
    public int point;
    public GameObject overPanel;
    public static Distro instance;
    public TextMeshProUGUI textMeshPro;
    // Start is called before the first frame update
    private void Awake()
    {
        instance = this;
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider collision)
    {
       if(collision.gameObject.CompareTag("Gift"))
        {
            Destroy(collision.gameObject);
            point += 1;
            Debug.Log("This is the destroying Script");
            textMeshPro.text=point.ToString("Score :" + point);
        }
       else if (collision.gameObject.CompareTag("Enemy"))
       {
            Destroy(gameObject);
            overPanel.SetActive(true);
            point = 0;


       }
    }
}
