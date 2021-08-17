using UnityEngine;
using TMPro;

public class TaskController : MonoBehaviour
{
    [Header("Timer")]
    [SerializeField] private TextMeshProUGUI timeText;
    [SerializeField] private float timeLeft;
    [SerializeField] private float timeAllowed;
    [Header("Tasks")]
    [SerializeField] private TextMeshProUGUI taskText;
    [SerializeField] private int currentTask;
    [SerializeField] private int tasksCompleted;

    private void Start()
    {
        timeLeft = timeAllowed;
    }

    private void Update()
    {
        Timer();
        TaskManager();
    }

    private void Timer()
    {
        timeLeft -= Time.deltaTime;
        timeText.text = timeLeft.ToString("0");

        if (timeLeft <= 0)
        {
            currentTask++;
            timeLeft = timeAllowed;
        }
    }

    private void TaskManager()
    {
        switch (currentTask)
        {
            case 1:
                taskText.text = "I want a picture of a lake!";
                break;
            case 2:
                taskText.text = "I want a picture of a cool tree!";
                break;
            case 3:
                taskText.text = "I want a picture of a ";
                break;
            case 4:
                taskText.text = "I want a picture of a ";
                break;
            case 5:
                taskText.text = "I want a picture of a ";
                break;
            default:
                break;
        }
    }

}
