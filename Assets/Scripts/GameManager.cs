using UnityEngine;
using TMPro;
/// <summary>
/// This class controls all global game mechanics such as timers.
/// </summary>
public class GameManager : MonoBehaviour
{
    [Header("Timer")]
    [SerializeField] private TextMeshPro timeText;
    [SerializeField] private float timeLeft;

    private void Update()
    {
        Timer();
    }

    private void Timer()
    {
        // if timeLeft is greater than 0
        if (timeLeft <= 0)
        {
            timeLeft = 0;
        }
        else
        {
            // timeLeft gradually decreases
            timeLeft -= Time.deltaTime;
            // updates the time display
            timeText.text = timeLeft.ToString("0"); 
        }
    }

}
