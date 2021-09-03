using UnityEngine;

public class CameraController : MonoBehaviour
{
    [SerializeField, Range(1, 10)] private float lookSpeed;
    [SerializeField, Range(1, 180)] private float upperLookLimit;
    [SerializeField, Range(1, 180)] private float lowerLookLimit;
    private float rotationX = 0.0f;

    private void Update()
    {
        Look();
    }

    private void Look()
    {
        // looking up and down is controlled by Input.GetAxis("Mouse Y")
        rotationX -= Input.GetAxis("Mouse Y") * lookSpeed;

        // clamping for realistic head movement
        rotationX = Mathf.Clamp(rotationX, -upperLookLimit, lowerLookLimit);

        // camera rotates towards where the player is looking
        transform.localRotation = Quaternion.Euler(rotationX, 0, 0);

        // the player's faces where the player is looking
        transform.parent.rotation *= Quaternion.Euler(0, Input.GetAxis("Mouse X") * lookSpeed, 0);
    }


}
