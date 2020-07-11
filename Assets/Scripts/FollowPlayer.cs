using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    // Instantiate variable to get pose of the player
    public Transform playerPose;
    public Vector3 camOffset;
    // Update is called once per frame
    void Update()
    {
        transform.position = playerPose.position + camOffset;
    }
}
