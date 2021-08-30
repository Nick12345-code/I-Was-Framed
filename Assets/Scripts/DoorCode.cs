using UnityEngine;
/// <summary>
/// This class controls the door code document
/// </summary>
public class DoorCode : MonoBehaviour
{
    [SerializeField] private Computer computer;
    [SerializeField] private GameObject doorCodeDocument;

    private void Update()
    {
        if (computer.hasInternet)
        {
            doorCodeDocument.SetActive(true);
        }
    }
}
