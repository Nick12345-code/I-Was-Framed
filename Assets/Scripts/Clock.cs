using System.Collections;
using UnityEngine;
using TMPro;
/// <summary>
/// This class controls the computer clock
/// </summary>
public class Clock : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI clockText;

    private void Start()
    {
        StartCoroutine(UpdateTime());
    }

    private IEnumerator UpdateTime()
    {
        while (true)
        {
            var today = System.DateTime.Now;
            clockText.text = today.ToString("HH:mm");
            yield return new WaitForSeconds(0.2f);
        }
    }

}
