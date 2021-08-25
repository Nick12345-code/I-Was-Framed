using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
/// <summary>
/// This class controls player interaction with the door
/// </summary>
public class Door : MonoBehaviour
{
    [Header("References")]
    [SerializeField] private PlayerController controller;
    [Header("Setup")]
    [SerializeField] private Camera playerCamera;
    [SerializeField] private GameObject doorCode;
    [SerializeField] private TMP_InputField codeInput;
    [SerializeField] private string code;
    [SerializeField] private float reach;
    [SerializeField] private bool inDoor;

    private void Update()
    {
        if (Input.GetMouseButtonDown(0) && !inDoor)
        {
            OpenDoorCode();
        }
        else if (Input.GetKeyDown(KeyCode.Escape) && inDoor)
        {
            CloseDoorCode();
        }

        if (Input.GetButtonDown("Submit") && inDoor)
        {
            CheckCode();
        }
    }

    private void OpenDoorCode()
    {
        // stores information on what ray hits
        RaycastHit hit;
        // the ray is shot from the center of the screen as player mouse position is locked
        Ray ray = playerCamera.ScreenPointToRay(Input.mousePosition);

        // ray is casted out at the distance specified by reach
        if (Physics.Raycast(ray, out hit, reach))
        {
            // if the ray hits an object tagged "Speaker"
            if (hit.collider.CompareTag("Door"))
            {
                controller.CanMove = false;
                inDoor = true;
                doorCode.SetActive(true);
                Cursor.lockState = CursorLockMode.None;
                Cursor.visible = true;               
            }
        }   
    }

    private void CloseDoorCode()
    {
        controller.CanMove = true;
        inDoor = false;
        doorCode.SetActive(false);
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }

    private void CheckCode()
    {
        if (codeInput.text == code)
        {
            // player escapes
            SceneManager.LoadScene("End");
        }
        else
        {
            // wrong code
        }
    }

}
