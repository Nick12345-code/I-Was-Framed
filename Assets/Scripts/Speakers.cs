using UnityEngine;

public class Speakers : MonoBehaviour
{
    [SerializeField] private Camera playerCamera;
    [SerializeField] private bool music;
    [SerializeField] private float reach;
    [SerializeField] private AudioSource speakers;

    private void Update()
    {
        // if left mouse button is clicked and music is on
        if (Input.GetMouseButtonDown(0) && music)
        {
            // turn music off
            TurnOff();
        }
        // else if left mouse button is clicked and music isn't on 
        else if (Input.GetMouseButtonDown(0) && !music)
        {
            // turn music on
            TurnOn();
        }
    }

    private void TurnOff()
    {
        // stores information on what ray hits
        RaycastHit hit;
        // the ray is shot from the center of the screen as player mouse position is locked
        Ray ray = playerCamera.ScreenPointToRay(Input.mousePosition);

        // ray is casted out at the distance specified by reach
        if (Physics.Raycast(ray, out hit, reach))
        {
            // if the ray hits an object tagged "Speaker"
            if (hit.collider.CompareTag("Speaker"))
            {
                // disables the music
                speakers.enabled = false;
                music = false;
            }
        }
    }

    private void TurnOn()
    {
        // stores information on what ray hits
        RaycastHit hit;
        // the ray is shot from the center of the screen as player mouse position is locked
        Ray ray = playerCamera.ScreenPointToRay(Input.mousePosition);

        // ray is casted out at the distance specified by reach
        if (Physics.Raycast(ray, out hit, reach))
        {
            // if the ray hits an object tagged "Speaker"
            if (hit.collider.CompareTag("Speaker"))
            {
                // enables the music
                speakers.enabled = true;
                music = true;
            }
        }
    }
}
