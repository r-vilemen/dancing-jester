using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Pause : MonoBehaviour
{
    public bool isPaused;
    public GameObject pauseUI;
    // Start is called before the first frame update
    void Start()
    {
        isPaused = false;

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyUp(KeyCode.Escape) && isPaused == false)
        {
            Paused();
        }
        else if (isPaused == true)
        {
            if (Input.GetKeyUp(KeyCode.Escape))
            {
                Resume();
            }
        }
    }

    public void Resume()
    {
        pauseUI.SetActive(false);
        Time.timeScale = 1f;
        isPaused = false;

    }
    public void Paused()
    {
        pauseUI.SetActive(true);
        Time.timeScale = 0f;

    }
    public void LoadMenu()
    {
        SceneManager.LoadScene("Menu");
    }
    public void LoadRestart()
    {
        SceneManager.LoadScene(0);
    }
}
