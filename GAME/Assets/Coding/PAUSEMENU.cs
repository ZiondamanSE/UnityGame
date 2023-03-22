using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class PAUSEMENU : MonoBehaviour
{
    public static bool isGamePause = false;

    [SerializeField] GameObject Pausemanu;
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (isGamePause)
            {
                ResumeGame();
            }
            else
            {
                PauseGame();
            }
        }
    }

   public void ResumeGame()
    {
        Pausemanu.SetActive(false);
        Time.timeScale = 1f;
        isGamePause = false;
    }

    void PauseGame()
    {
        Pausemanu.SetActive(true);
        Time.timeScale = 0f;
        isGamePause = true;
    }

    public void LoadMenu()
    {
        SceneManager.LoadScene(0);
    }

    public void QuitGame()
    {
        Application.Quit();
        Debug.Log("end gmae");
    }
}
