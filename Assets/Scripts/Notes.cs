using UnityEngine;

public class Notes : MonoBehaviour
{
    [Header("References")]
    [SerializeField] private Interaction interaction;
    [Header("Notes")]
    [SerializeField] private GameObject[] notes;

    private void Update()
    {
        interaction.Start("Note1", notes[0]);
        interaction.Start("Note2", notes[1]);

        interaction.Stop(notes[0]);
        interaction.Stop(notes[1]);
    }
}
