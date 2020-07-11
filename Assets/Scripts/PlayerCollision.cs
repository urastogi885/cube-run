using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    // Instantiate an object of the player-movement class
    public PlayerMovement playerMovement;
    void OnCollisionEnter(Collision collisionInfo)
    {
        if (collisionInfo.collider.tag == "Obstacle")
        {
            // Stop player movement upon collision with an obstacle
            playerMovement.enabled = false;
            FindObjectOfType<GameManager>().EndGame();
        }
    }
}
