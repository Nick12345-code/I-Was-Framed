using UnityEngine;
using TMPro;
/// <summary>
/// This class displays the name of attached GameObjects
/// </summary>
public class Label : MonoBehaviour
{
    private TextMeshProUGUI label;

    private void Start()
    {
        label = GameObject.Find("Label").GetComponent<TextMeshProUGUI>();
        label.text = "";
    }

    //If your mouse hovers over the GameObject with the script attached, output this message
    private void OnMouseOver()
    {
        label.text = $"{gameObject.name}";
    }

    //The mouse is no longer hovering over the GameObject so output this message each frame
    private void OnMouseExit()
    {
        label.text = "";
    }
}
