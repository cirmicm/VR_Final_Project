using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void PlayGame()
    {
        // Loads the next scene index in your Build Settings
        SceneManager.LoadScene("Game_Scene");
    }

    public void OpenSettings()
    {
        Debug.Log("Opening Settings...");
        // Add your settings panel toggle logic here
    }

    public void QuitGame()
    {
        Debug.Log("Game is exiting...");
        
        // Quits the application (Works in exported builds)
        Application.Quit();

        // If you are testing inside the Unity Editor, stop playing the scene
        #if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
        #endif
    }
}