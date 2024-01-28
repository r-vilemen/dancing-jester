using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Buttons : MonoBehaviour
{
    public GameObject soundSettings;
    public Slider soundSlider;
    // Start is called before the first frame update
    void Start()
    {
        soundSettings.SetActive(false); 
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void LoadMenu()
    {
        SceneManager.LoadScene("Menu");
        Time.timeScale = 1f;
    }
    public void Loadfase()
    {
        SceneManager.LoadScene(2);
        Time.timeScale = 1f;
    }

    public void LoadCredits()
    {
        SceneManager.LoadScene("Credits");
    }
    public void LoadSoundBt()
    {
        soundSettings.SetActive(true);
        StartCoroutine(LoadSoundTimer());
    }
    public void Quit()
    {
        Application.Quit();
    }


    IEnumerator LoadSoundTimer()
    {
        yield return new WaitForSeconds(5);
        soundSettings.SetActive(false);
    }

}
