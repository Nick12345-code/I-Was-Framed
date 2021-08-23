using UnityEngine;
using TMPro;
/// <summary>
/// This class controls picking up and reading notes
/// </summary>
public class Pickup : MonoBehaviour
{
    [Header("References")]
    [SerializeField] private Concentration con;
    [Header("Setup")]
    [SerializeField] private Camera playerCamera;
    [SerializeField] private float reach;
    [SerializeField] private TextMeshProUGUI dialogue;
    [SerializeField] private string[] jumbledNotes;
    [SerializeField] private string[] notes;

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            ReadNote();
        }
    }

    private void ReadNote()
    {
        // stores information on what ray hits
        RaycastHit hit;
        // the ray is shot from the center of the screen as player mouse position is locked
        Ray ray = playerCamera.ScreenPointToRay(Input.mousePosition);

        // ray is casted out at the distance specified by reach
        if (Physics.Raycast(ray, out hit, reach))
        {
            // if the ray hits an object tagged "Computer"
            switch (hit.collider.name)
            {
                case "Note 1":
                    FadeIn(0);
                    break;
                default:
                    break;
            }
        }
    }

    // fade in text
    private void FadeIn(int index)
    {
        // fades in text over time
        dialogue.CrossFadeAlpha(1, 1, true);       

        // if player isn't concentrating enough
        if (con.concentration <= 50)
        {
            // dialogue will be jumbled
            dialogue.text = jumbledNotes[index];   
        }
        else
        {
            // else dialogue will be normal
            dialogue.text = notes[index];
        }

        // invoke FadeOut function after 5 seconds
        Invoke("FadeOut", 5);                       
    }

    // fade out text
    private void FadeOut()
    {
        // fades out text over time
        dialogue.CrossFadeAlpha(0, 1, true);    
    }
}
