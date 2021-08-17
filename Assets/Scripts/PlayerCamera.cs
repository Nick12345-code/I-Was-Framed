using UnityEngine;
/// <summary>
/// This script controls camera which follows the player
/// </summary>
public class PlayerCamera : MonoBehaviour
{
    [SerializeField] private Transform player;
    [SerializeField] private Vector3 offset;
    [SerializeField] private float speed;

    // MoveCamera() function placed in LateUpdate() so there is no glitchiness as this updates at the end of the frame
    private void LateUpdate()
    {
        MoveCamera();
    }

    private void MoveCamera()
    {
        // smoothly moves the camera to the offset position
        transform.position = Vector3.Lerp(transform.position, player.position + offset, speed * Time.deltaTime);
    }
}
