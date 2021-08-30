using UnityEngine;
using UnityEngine.UI;

public class Concentration : MonoBehaviour
{
    [Header("References")]
    [SerializeField] private BlinkController blink;
    [Header("Setup")]
    public float concentration;
    [SerializeField] private float loseSpeed;
    [SerializeField] private float gainSpeed;
    [SerializeField] private float minConcentration;
    [SerializeField] private float maxConcentration;
    [SerializeField] private Image fill;
    [SerializeField] private Image background;

    private void Start()
    {
        fill.fillAmount = maxConcentration;
        background.fillAmount = maxConcentration;
    }

    private void Update()
    {
        LoseConcentration();
    }

    private void LoseConcentration()
    {
        if (!blink.isBlinking)
        {
            // if concentration is above 0
            if (concentration >= minConcentration)
            {
                // decrease concentration over time
                concentration -= Time.deltaTime * loseSpeed;

                // update concentration bar
                fill.fillAmount = concentration / 100;
            } 
        }
        else if (blink.isBlinking)
        {
            // if concentration is above 0
            if (concentration <= maxConcentration)
            {
                // decrease concentration over time
                concentration += Time.deltaTime * gainSpeed;

                // update concentration bar
                fill.fillAmount = concentration / 100;
            }
        }
    }

}
