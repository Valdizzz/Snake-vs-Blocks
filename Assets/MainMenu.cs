using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
   // public int SampleScene { get; private set; }

    public void PlayGame()
    {
        SceneManager.LoadScene("SampleScene");
       // SceneManager.UnloadSceneAsync("Menu");
    }

    public void QuitGame()
    {
        Application.Quit();
    }

    private void Awake()
    {
        
       // Debug.Log("Scene Main menu" + SceneManager.GetActiveScene().buildIndex);
       //SceneManager.LoadScene("Menu");
    }
}
