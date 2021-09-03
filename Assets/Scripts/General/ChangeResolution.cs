using UnityEngine;
using System.Collections.Generic;
using TMPro;
/// <summary>
/// This class allows the resolution to be changed.
/// </summary>
public class ChangeResolution : MonoBehaviour
{
    [SerializeField] private TMP_Dropdown resolutionDropdown;   // dropdown that displays resolutions
    [SerializeField] private Resolution[] resolutions;

    void Start()
    {
        AddResolutions();
    }

    private void AddResolutions()
    {
        // array of available resolutions
        resolutions = Screen.resolutions;

        // clears the dropdown
        resolutionDropdown.ClearOptions();

        // creates a list of options
        List<string> options = new List<string>();

        // the current resolution index
        int currentResolutionIndex = 0;

        // for all resolutions 
        for (int i = 0; i < resolutions.Length; i++)
        {
            // display the resolution as a string
            string option = resolutions[i].width + " x " + resolutions[i].height;

            // add that option to the options list
            options.Add(option);

            // if the current resolution of the computer is found, set it to the first option
            if (resolutions[i].width == Screen.currentResolution.width && resolutions[i].height == Screen.currentResolution.height)
            {
                currentResolutionIndex = i;
            }
        }

        // add the resolutions to the dropdown
        resolutionDropdown.AddOptions(options);

        // the default dropdown value is set to 0
        resolutionDropdown.value = currentResolutionIndex;

        // refreshes the dropdown display
        resolutionDropdown.RefreshShownValue();
    }

    public void SwitchResolution(int resolutionIndex)
    {
        Resolution res = resolutions[resolutionIndex];
        Screen.SetResolution(res.width, res.height, Screen.fullScreen);
    }
}
