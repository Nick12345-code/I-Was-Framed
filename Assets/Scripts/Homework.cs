using UnityEngine;
using System.Collections.Generic;
using TMPro;
/// <summary>
/// This class controls the ingame homework mechanic
/// </summary>
public class Homework : MonoBehaviour
{
    [SerializeField] private Dictionary<string, string> Questions = new Dictionary<string, string>();
    [SerializeField] private TextMeshProUGUI solvedText;
    [SerializeField] private TMP_InputField[] questions;
    [SerializeField] private string[] answers;
    [SerializeField] private int correctAnswers;

    private void Start()
    {
        Questions.Add(questions[0].text, answers[0]);
        Questions.Add(questions[1].text, answers[1]);
        Questions.Add(questions[2].text, answers[2]);
        Questions.Add(questions[3].text, answers[3]);
        Questions.Add(questions[4].text, answers[4]);
    }

    private void Update()
    {      
        Check();
    }

    private void CheckAnswer(string answer)
    {
        //return Questions.ContainsKey(answer);
    }

    public void Check()
    {
        solvedText.text = $"{correctAnswers} / 5";

        if (correctAnswers == 5)
        {
            solvedText.text = "You solved all the questions!";
        }
        else
        {
            switch (Questions.ContainsKey(""))
            {
                default:
                    break;
            }
        }
    }
}
