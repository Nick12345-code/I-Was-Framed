using UnityEngine;
/// <summary> This script controls player movement. /// </summary>
public class PlayerController : MonoBehaviour
{
    [Header("Movement")]
    [SerializeField] private float speed;
    [SerializeField] private Animator animator;
    [SerializeField] private Rigidbody2D rb;
    private Vector2 movement;
    [Header("Interaction")]
    [SerializeField] private GameObject TaskInfo;

    private void Update()
    {
        // gets the horizontal and vertical axes (for WASD movement)
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");

        // sets the animator parameters
        animator.SetFloat("Horizontal", movement.x);
        animator.SetFloat("Vertical", movement.y);

        // sqrMagnitude is more optimised than just magnitude as it has already done the square root calculation
        animator.SetFloat("Speed", movement.sqrMagnitude);

        TaskInformation();
    }

    private void FixedUpdate()
    {
        // Time.fixedDeltaTime makes this update at fixed intervals
        rb.MovePosition(rb.position + movement.normalized * speed * Time.fixedDeltaTime);
    }

    private void TaskInformation()
    {
        // hiding & showing the task information
        if (Input.GetKeyDown(KeyCode.I))
        {
            if (TaskInfo.activeSelf)
            {
                TaskInfo.SetActive(false);
            }
            else
            {
                TaskInfo.SetActive(true);
            }
        }
    }
}
