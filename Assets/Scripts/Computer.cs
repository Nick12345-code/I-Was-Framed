using UnityEngine;
using TMPro;
using UnityEngine.UI;
/// <summary>
/// This class controls the ingame computer feature
/// </summary>
public class Computer : MonoBehaviour
{
    [Header("References")]
    public PlayerController controller;
    [Header("Setup")]
    public bool inComputer;
    [SerializeField] private GameObject computerScreen;
    [SerializeField] private Camera playerCamera;
    [SerializeField] private float reach;
    [Header("Login")]
    [SerializeField] private GameObject loginScreen;
    [SerializeField] private TMP_InputField inputText;
    [SerializeField] private Image background;
    [SerializeField] private Color normal;
    [SerializeField] private Color fail;
    [SerializeField] private string password;

    private void Start()
    {
        computerScreen.SetActive(false);
    }

    private void Update()
    {
        // if left mouse button is clicked and the player is not in the computer 
        if (Input.GetMouseButtonDown(0) && !inComputer)
        {
            // use the computer
            UseComputer();
        }
        else if (Input.GetKeyDown(KeyCode.Escape) && inComputer)
        {
            ComputerOff();
        }

        if (Input.GetKeyDown(KeyCode.KeypadEnter))
        {
            Password(); 
        }
    }

    private void UseComputer()
    {
        // stores information on what ray hits
        RaycastHit hit;
        // the ray is shot from the center of the screen as player mouse position is locked
        Ray ray = playerCamera.ScreenPointToRay(Input.mousePosition);

        // ray is casted out at the distance specified by reach
        if (Physics.Raycast(ray, out hit, reach))
        {
            // if the ray hits an object tagged "Computer"
            if (hit.collider.CompareTag("Computer"))
            {
                ComputerOn();
            }
        }
    }

    // computer is being used
    private void ComputerOn()
    {
        computerScreen.SetActive(true);     // computer screen is enabled
        controller.CanMove = false;         // player controller is frozen
        inComputer = true;                  // player is confirmed to be in the computer

        // unlocks and enables cursor
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
    }

    // computer is not being used
    private void ComputerOff()
    {
        computerScreen.SetActive(false);    // computer screen is enabled
        controller.CanMove = true;          // player controller is frozen
        inComputer = false;                 // player is confirmed to be in the computer

        // locks and disables cursor
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }

    private void Password()
    {
        if (inputText.text == password)
        {
            // logged in to computer
            print("successful login!");
            loginScreen.SetActive(false);
        }
        else
        {
            print("login failed!");
            background.color = fail;
            Invoke("NormalColour", 1);
        }
    }

    private void NormalColour()
    {
        background.color = normal;
    }
}
