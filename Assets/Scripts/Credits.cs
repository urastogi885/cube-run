using UnityEngine;
using UnityEngine.SceneManagement;

public class Credits : MonoBehaviour
{
    public void QuitGame()
    {
        Debug.Log("Player has quit the game!");
        Application.Quit();
    }

    public void RestartGame()
    {
        Debug.Log("Game started!");
        SceneManager.LoadScene(1);
    }

    public void ReturnToMainMenu()
    {
        Debug.Log("Return back to the main menu");
        SceneManager.LoadScene(0);
    }
}
