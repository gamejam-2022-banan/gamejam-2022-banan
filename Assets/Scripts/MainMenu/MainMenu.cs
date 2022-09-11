using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
  
    public void playGame()
    {
        Debug.Log("Play Game has been pressed");
        //SceneManager.LoadScene(1); 
        //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1); 
        SceneManager.LoadScene("Scenes/rkh1");
        // tekur n�sta scenuna um ta� skal vera �v�s scena mugu vit specifisera ta� � SceneManager
        // er � "File" "Build And Run" og Scenes in build skal h�la scenurnar inn.
    }

    public void GoToSettingsMenu()
    {
        Debug.Log("Settings has been pressed");
        SceneManager.LoadScene("SettingsMenuScene");
    }

    public void GoToMainMenu()
    {
        Debug.Log("Back has been pressed");
        SceneManager.LoadScene("MainMenuScene");
    }

    public void quitGame()
    {
        Debug.Log("Quit Game has been pressed");
        Application.Quit();
    }
}
