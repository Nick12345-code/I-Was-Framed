using UnityEngine;
/// <summary>
/// This class allows settings such as framerate limits and resolution to be changed
/// </summary>
public class Settings : MonoBehaviour
{
    private void LimitFramerate(int target)
    {
        Application.targetFrameRate = target;
    }
}
