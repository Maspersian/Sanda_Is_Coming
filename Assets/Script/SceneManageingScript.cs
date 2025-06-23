using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneManageingScript : MonoBehaviour
{
    public GameObject panelAbout;
    public GameObject aboutButton;
    public GameObject playButton;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void PlayGame()
    {
        SceneManager.LoadScene(0);
        //Distro.instance.overPanel.SetActive(false);

    }
    public void HomeGame()
    {
        Distro.instance.overPanel.SetActive(false);
        SceneManager.LoadScene(1);

    }
    public void HidePanel()
    {
        panelAbout.SetActive(false);
        playButton.SetActive(true);
        aboutButton.SetActive(true);
    }
    public void ShowPanel()
    {
        panelAbout.SetActive(true);
        playButton.SetActive(false);
        aboutButton.SetActive(false);
    }
}
