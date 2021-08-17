using UnityEngine;
using TMPro;
/// <summary>
/// This class controls the in-game camera feature
/// </summary>
public class CameraController : MonoBehaviour
{
    [SerializeField] private bool processing;       // whether a picture is currently being taken
    [SerializeField] private Animator lens;         // the Animator component
    [SerializeField] private TextMeshProUGUI memoryText;
    [SerializeField] private int memoryLeft;

    private void Update()
    {
        // if space button is pressed
        if (Input.GetKeyDown(KeyCode.Space))
        {
            // if not processing
            if (!processing && memoryLeft >= 1)
            {
                // take a picture
                Processing();
            }
            else if (processing)
            {
                // you are already taking a picture
                print("You are currently taking a picture!");
            }
            else if (memoryLeft <= 0)
            {
                // lose the game
                print("You have no memory left in the camera!");
            }
        }
    }

    private void Processing()
    {
        processing = true;              // currently taking a photo
        lens.Play("TakePicture");       // play lens animation
        memoryLeft--;                   // lose some memory
        memoryText.text = memoryLeft.ToString();
        Invoke("Processed", 1);         // processing is finished after 1 second
    }

    private void Processed()
    {
        processing = false;             // photo has been taken
    }

    private void MouseHover()
    {
        if (Input.GetMouseButtonDown(0))
        {
            RaycastHit hit;
            if (Physics.Raycast(transform.position, Vector2.up, out hit, 1.0f))
            {
                if (hit.collider.CompareTag("PinkHouse"))
                {

                }
            }
        }
    }
}