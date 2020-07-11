using UnityEngine;

public class EndTrigger : MonoBehaviour
{
    public GameManager gameManager;
    // Method to trigger end of a level in the game
    private void OnTriggerEnter()
    {
        Debug.Log("Level Completed!");
        gameManager.CompleteLevel();
    }
}
