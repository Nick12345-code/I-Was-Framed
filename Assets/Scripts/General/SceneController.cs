using UnityEngine;
using UnityEngine.SceneManagement;
/// <summary>
/// Controls changing scenes.
/// </summary>
public class SceneController : MonoBehaviour
{
    /// <summary>
    /// This function loads a scene.
    /// </summary>
    /// <param name="name"> The name of the scene being loaded is specified in the inspector. </param>
    public void ChangeScene(string name)
    {       
        SceneManager.LoadScene(name);
    }
}
