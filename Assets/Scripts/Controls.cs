using UnityEngine;
using UnityEngine.SceneManagement;

public class Controls : MonoBehaviour
{
    public void ReturnToMainMenu()
    {
        Debug.Log("Return back to the main menu");
        SceneManager.LoadScene(0);
    }
}
