using UnityEngine;
using TMPro;
/// <summary>
/// This class controls the lives the player has
/// </summary>
public class Health : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI livesText;
    [SerializeField] private int lives;
    [SerializeField] private int maxLives;

    private void Start()
    {
        lives = maxLives;
        livesText.text = lives.ToString();
    }

    public void LoseLives(int amount)
    {
        lives -= amount;
        livesText.text = lives.ToString();
    }
}
