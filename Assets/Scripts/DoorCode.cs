using UnityEngine;

public class DoorCode : MonoBehaviour
{
    [SerializeField] private Computer computer;
    [SerializeField] private GameObject doorCode;

    private void Update()
    {
        if (computer.hasInternet)
        {
            doorCode.SetActive(true);
        }
    }
}
