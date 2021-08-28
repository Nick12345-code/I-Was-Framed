using UnityEngine;
using UnityEngine.SceneManagement;
/// <summary>
/// This class has a public function which can be called to change scenes
/// </summary>
public class SceneController : MonoBehaviour
{
    public void ChangeScene(string name)
    {
        SceneManager.LoadScene(name);
    }
}
