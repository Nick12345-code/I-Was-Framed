using UnityEngine;
/// <summary>
/// This class controls the in-game camera feature
/// </summary>
public class CameraController : MonoBehaviour
{
    [SerializeField] private bool processing;       // whether a picture is currently being taken
    [SerializeField] private Animator lens;         // the Animator component

    private void Update()
    {
        // if space button is pressed
        if (Input.GetKeyDown(KeyCode.Space))
        {
            // if not processing
            if (!processing)
            {
                // take a picture
                Processing(); 
            }
            else
            {
                // you are already taking a picture
                print("You are currently taking a picture!");
            }
        }
    }

    private void Processing()
    {
        processing = true;              // currently taking a photo
        lens.Play("TakePicture");       // play lens animation
        Invoke("Processed", 1);         // processing is finished after 1 second
    }

    private void Processed()
    {
        processing = false;             // photo has been taken
    }
}
