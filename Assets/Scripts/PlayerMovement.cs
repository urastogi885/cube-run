using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody rigidBody;
    public float forwardForce = 1000f;
    public float sideForce = 50f;

    // Use fixed update instead of update method to manipulate unity physics
    // Update is called once per frame
    void FixedUpdate()
    {
        // Add a forward force to the player
        rigidBody.AddForce(0, 0, forwardForce * Time.smoothDeltaTime);
        // Get user input to move the player in various directions
        // Move player right
        if (Input.GetKey("a"))
        {
            rigidBody.AddForce(-sideForce * Time.smoothDeltaTime, 0, 0, ForceMode.VelocityChange);
        }
        // Move player left
        else if (Input.GetKey("d"))
        {
            rigidBody.AddForce(sideForce * Time.smoothDeltaTime, 0, 0, ForceMode.VelocityChange);
        }

        if (rigidBody.position.y < -1)
        {
            FindObjectOfType<GameManager>().EndGame();
        }
    }
}
