using UnityEngine;
using UnityEngine.UI; // For working with UI elements like Button
using TMPro; // For TextMeshPro, though not directly needed for this script
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour{
    public void PlayGame()
    {
        SceneManager.LoadSceneAsync("Scene1");
    }
    public void QuitGame()
    {
        Application.Quit();
        Debug.Log("Game Quit Successfully!");
    }

}