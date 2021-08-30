using UnityEngine;
using TMPro;

public class Homework : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI solvedText;    // text that displays how many correct answers player has
    [SerializeField] private TMP_InputField[] questions;    // array of input fields, each holding a question
    [SerializeField] private string[] answers;              // array of strings, each holding an answer
    [SerializeField] private bool[] isCorrect;              // array of bools, each representing if a question is solved
    [SerializeField] private int correctAnswers;            // the number of correctly answered questions

    private void Update()
    {
        CheckAnswer();
    }

    /// <summary> If the inputted data of an input field matches the relevant answer, that question becomes solved. </summary>
    public void CheckAnswer()
    {
        if (questions[0].text == answers[0] && !isCorrect[0])
        {
            correctAnswers += 1;
            solvedText.text = correctAnswers.ToString() + " / 5 solved!";
            questions[0].enabled = false;
            isCorrect[0] = true;
        }
        else if (questions[1].text == answers[1] && !isCorrect[1])
        {
            correctAnswers += 1;
            solvedText.text = correctAnswers.ToString() + " / 5 solved!";
            questions[1].enabled = false;
            isCorrect[1] = true;
        }
        else if (questions[2].text == answers[2] && !isCorrect[2])
        {
            correctAnswers += 1;
            solvedText.text = correctAnswers.ToString() + " / 5 solved!";
            questions[2].enabled = false;
            isCorrect[2] = true;
        }
        else if (questions[3].text == answers[3] && !isCorrect[3])
        {
            correctAnswers += 1;
            solvedText.text = correctAnswers.ToString() + " / 5 solved!";
            questions[3].enabled = false;
            isCorrect[3] = true;
        }
        else if (questions[4].text == answers[4] && !isCorrect[4])
        {
            correctAnswers += 1;
            solvedText.text = correctAnswers.ToString() + " / 5 solved!";
            questions[4].enabled = false;
            isCorrect[4] = true;
        }
    }
}

