using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class Computer : MonoBehaviour
{
    [Header("References")]
    public PlayerController controller;
    [Header("Setup")]
    public bool inComputer;
    [SerializeField] private GameObject computerScreen;
    [SerializeField] private Camera playerCamera;
    [SerializeField] private float reach;
    [Header("Login Screen")]
    [SerializeField] private GameObject loginScreen;
    [SerializeField] private TMP_InputField loginInput;
    [SerializeField] private Image background;
    [SerializeField] private Color normal;
    [SerializeField] private Color fail;
    [SerializeField] private string password;
    [SerializeField] private bool loggedIn;
    [Header("Wifi Screen")]
    [SerializeField] private TMP_InputField wifiInput;
    [SerializeField] private TextMeshProUGUI resultText;
    [SerializeField] private GameObject green;
    [SerializeField] private string passcode;
    public bool hasInternet;

    private void Start()
    {
        computerScreen.SetActive(false);
        green.SetActive(false);
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

        if (Input.GetButtonDown("Submit"))
        {
            if (!loggedIn)
            {
                LogIn();  
            }
            else
            {
                ConnectWifi();
            }
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

    private void LogIn()
    {
        if (loginInput.text == password)
        {
            // logged in to computer
            loginScreen.SetActive(false);
            loggedIn = true;
        }
        else
        {
            background.color = fail;
            Invoke("NormalColour", 1);
        }
    }

    private void NormalColour()
    {
        background.color = normal;
    }

    private void ConnectWifi()
    {
        if (wifiInput.text == passcode)
        {
            resultText.text = "Connection Successful!";
            hasInternet = true;
            green.SetActive(true);
        }
        else
        {
            resultText.text = "Connection Failed!";
        }
    }
}
