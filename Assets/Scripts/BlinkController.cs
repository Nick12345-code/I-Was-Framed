using UnityEngine;

public class BlinkController : MonoBehaviour
{
    public bool isBlinking;
    [SerializeField] private Animator eyes;         

    private void Update()
    {
        // if space button is pressed
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Blink();
        }
    }

    public void Blink()
    {
        // if not currently blinking
        if (!isBlinking)
        {
            // blink
            Blinking();
        }
    }

    private void Blinking()
    {
        isBlinking = true;              // currently blinking
        eyes.Play("Blink");             // play blinking animation
        Invoke("Blinked", 1);           // blinking is finished after 1 second
    }

    private void Blinked()
    {
        isBlinking = false;             // player has blinked
    }
}