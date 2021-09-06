using UnityEngine;
using UnityEngine.UI;

public class ChangeFramerate : MonoBehaviour
{
    [SerializeField] private int target;                // the target framerate
    [SerializeField] private Text targetText;           // target display
    [SerializeField] private Slider framerateSlider;    // framerate slider        

    void Awake()
    {
        framerateSlider.minValue = 30;          // minimum framerate
        framerateSlider.maxValue = 120;         // maximum framerate
        framerateSlider.value = target;         // framerate slider value is defaulted to the target

        QualitySettings.vSyncCount = 0;         // sets vSync count to 0
        Application.targetFrameRate = target;   // sets the framerate to the target
        targetText.text = target.ToString();    // updates target text display
    }

    private void Update()
    {
        // changes framerate
        SwitchFramerate();
    }

    /// <summary>
    /// Allows framerate to change when slider value is changed.
    /// </summary>
    public void SwitchFramerate()
    {
        // framerate equals the slider value
        Application.targetFrameRate = (int)framerateSlider.value;

        // target equals slider value
        target = (int)framerateSlider.value;

        // updates target text display
        targetText.text = target.ToString();
    }
}
