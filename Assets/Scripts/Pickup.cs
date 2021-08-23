using UnityEngine;
using TMPro;
/// <summary>
/// This class controls picking up and reading notes
/// </summary>
public class Pickup : MonoBehaviour
{
    [SerializeField] private Camera playerCamera;
    [SerializeField] private float reach;
    [SerializeField] private TextMeshProUGUI dialogue;
    [SerializeField] private string[] messyNotes;
    [SerializeField] private string[] neatNotes;

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
                case "Note1":
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
        dialogue.CrossFadeAlpha(1, 1, true);    // fades in text over time
        dialogue.text = messyNotes[index];      // text displayed depends on array
        Invoke("FadeOut", 5);                   // invoke FadeOut function after 5 seconds
    }

    // fade out text
    private void FadeOut()
    {
        dialogue.CrossFadeAlpha(0, 1, true);    // fades out text over time
    }
}
