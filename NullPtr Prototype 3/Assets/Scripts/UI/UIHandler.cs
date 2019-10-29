using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIHandler : MonoBehaviour {

    private SceneSwitcher sceneSwitch;
    private string sName;
    public bool canPause = true;
    public bool isPaused = false;

    // Use this for initialization
    void Start () {
        sceneSwitch = GetComponent<SceneSwitcher>();

        sName = SceneManager.GetActiveScene().name;
        if (sName == "MainMenu")
        {
            Time.timeScale = 1f;
        }
    }
	
	// Update is called once per frame
	void Update ()
    {
        if (sName == "MainMenu")
        {

        }

        else
        {
            if (Input.GetKeyDown(KeyCode.Escape))
            {
                if (canPause)
                {
                    PauseButton();
                }
            }
            if (Input.GetKeyDown(KeyCode.R))
            {
                Restart();
            }

            Time.timeScale = isPaused ? 0f : 1f;
        }

    }

    public void StartButton()
    {
        sceneSwitch.SceneSwitch(GlobalData.LastScene);
        Debug.Log("Hello");
    }

    public void MainMenuButton()
    {
        SceneManager.LoadScene("MainMenu");
    }

    public void PauseButton()
    {
        isPaused = !isPaused;
    }

    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void Quit()
    {
        Application.Quit();
    }

}
