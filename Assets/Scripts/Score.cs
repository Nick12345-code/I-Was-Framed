using UnityEngine;
using TMPro;
/// <summary>
/// This script controls the scoring system
/// </summary>
public class Score : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI scoreText;
    [SerializeField] private int score;
    [SerializeField] private int minScore;
    [SerializeField] private int maxScore;

    private void Start()
    {
        score = minScore;
        scoreText.text = score.ToString();
    }

    public void GainScore(int amount)
    {
        score += amount;
        scoreText.text = score.ToString();
    }

    public void LoseScore(int amount)
    {
        score -= amount;
        scoreText.text = score.ToString();
    }
}
