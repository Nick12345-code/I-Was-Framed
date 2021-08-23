using UnityEngine;
using TMPro;
using UnityEngine.Tilemaps;

public class GameManager : MonoBehaviour
{
    [Header("Timer")]
    [SerializeField] private TextMeshProUGUI timeText;
    [SerializeField] private float timeLeft;
    [SerializeField] private float timeAllowed;

    private void Start()
    {
        timeLeft = timeAllowed;
    }

    private void Update()
    {
        Timer();
    }

    private void Timer()
    {
        timeLeft -= Time.deltaTime;
        timeText.text = timeLeft.ToString("0");

        if (timeLeft <= 0)
        {          
            // load results screen
        }
    }
}
