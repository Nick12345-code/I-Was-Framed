using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

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
            SceneManager.LoadScene("Fail");
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
