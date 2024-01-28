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
    public void LoadRestartFase1()
    {
        SceneManager.LoadScene(2);
        Time.timeScale = 1f;
    }
    public void LoadRestartFase2()
    {
        SceneManager.LoadScene(3);
        Time.timeScale = 1f;
    }
    public void LoadRestartFase3()
    {
        SceneManager.LoadScene(0);
        Time.timeScale = 1f;
    }
}
