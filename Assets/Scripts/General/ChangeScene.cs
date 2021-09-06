using UnityEngine;
using UnityEngine.SceneManagement;
/// <summary>
/// Controls changing scenes.
/// </summary>
public class ChangeScene : MonoBehaviour
{
    /// <summary>
    /// This function loads a scene.
    /// </summary>
    /// <param name="name"> The name of the scene being loaded is specified in the inspector. </param>
    public void SwitchScene(string name)
    {       
        SceneManager.LoadScene(name);
    }
}
