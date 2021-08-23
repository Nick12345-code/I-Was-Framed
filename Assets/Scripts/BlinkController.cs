using UnityEngine;
using TMPro;
/// <summary>
/// This class controls the player's blinking mechanic
/// </summary>
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
        else if (isBlinking)
        {
            // you are currently blinking
            print("You are currently blinking!");
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

    // blink doesn't look like a real word now
}