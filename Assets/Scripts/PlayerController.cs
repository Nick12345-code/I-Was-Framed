using UnityEngine;

public class PlayerController : MonoBehaviour
{
    /// <summary> Whether the player can move or not. </summary>
    public bool canMove;
    [SerializeField] private float moveSpeed;
    [SerializeField] private float walkSpeed;
    [SerializeField] private float animationSmoothness;
    private Vector3 moveDirection;
    private CharacterController controller;
    private Animator playerAnimation;

    private void Start()
    {
        canMove = true;

        controller = GetComponent<CharacterController>();
        playerAnimation = GetComponentInChildren<Animator>();

        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }

    private void Update()
    {
        if (canMove)
        {
            Move(); 
        }
    }

    private void Move()
    {
        float moveZ = Input.GetAxis("Vertical");
        moveDirection = new Vector3(0, 0, moveZ);
        moveDirection = transform.TransformDirection(moveDirection);

        if (moveDirection != Vector3.zero)
        {
            moveSpeed = walkSpeed;
            playerAnimation.SetFloat("Speed", 1, animationSmoothness, Time.deltaTime);
        }
        else if (moveDirection == Vector3.zero)
        {
            playerAnimation.SetFloat("Speed", 0, animationSmoothness, Time.deltaTime);
        }
        moveDirection *= moveSpeed;
        controller.Move(moveDirection * Time.deltaTime);
    }
}
