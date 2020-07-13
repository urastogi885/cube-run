using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    // Method to start the game
    public void StartGame()
    {
        Debug.Log("Game started!");
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    // Method to go to control settings scene
    public void ControlSettings()
    {
        Debug.Log("Switched to control settings scene");
        // SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    // Method to exit the game
    public void QuitGame()
    {
        Debug.Log("Player has quit the game!");
        Application.Quit();
    }
}
