using UnityEngine;
/// <summary>
/// This script controls player movement.
/// </summary>
public class PlayerController : MonoBehaviour
{
    [SerializeField] private float speed;

    private void Update()
    {
        Movement();
    }

    private void Movement()
    {
        // gets the horizontal and vertical axes (for WASD movement)
        float horizontal = Input.GetAxisRaw("Horizontal");
        float vertical = Input.GetAxisRaw("Vertical");

        // puts these axes into a Vector2
        Vector2 movement = new Vector2(horizontal, vertical);

        // depending on which key is pressed the player moves in that direction
        transform.Translate(movement * speed * Time.deltaTime, Space.World);
    }
}
