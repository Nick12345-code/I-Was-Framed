using UnityEngine;
using TMPro;
/// <summary>
/// This script controls the intuition scoring system
/// </summary>
public class Intuition : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI intuitionText;
    [SerializeField] private int intuition;
    [SerializeField] private int maxIntuition;
    [SerializeField] private int minIntuition;

    private void Start()
    {
        intuition = minIntuition;
        intuitionText.text = intuition.ToString();
    }
}
