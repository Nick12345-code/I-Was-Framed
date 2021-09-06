using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class Door : MonoBehaviour
{
    [Header("References")]
    [SerializeField] private Interaction interaction;
    [Header("Setup")]
    [SerializeField] private GameObject doorCode;
    [SerializeField] private TMP_InputField input;
    [SerializeField] private string code;

    private void Update()
    {
        interaction.Start("Door", doorCode);
        interaction.Stop(doorCode);

        if (input.text == code) SceneManager.LoadScene("Win");
    }
}
