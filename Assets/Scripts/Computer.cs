using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class Computer : MonoBehaviour
{
    [Header("References")]
    [SerializeField] private Interaction interaction;
    [Header("Setup")]
    [SerializeField] private GameObject computerScreen;
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

    private void Update()
    {
        interaction.Start("Computer", computerScreen);
        interaction.Stop(computerScreen);

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
