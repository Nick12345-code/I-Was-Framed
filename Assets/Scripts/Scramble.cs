using UnityEngine;
using TMPro;

public class Scramble : MonoBehaviour
{
    [SerializeField] private Concentration concentrate;
    [SerializeField] private TextMeshProUGUI pressSpaceToBlink;

    private void Update()
    {
        ScrambleText();
    }

    public string ScrambleWord(string word)
    {
        char[] chars = new char[word.Length];
        int index = 0;
        while (word.Length > 0)
        { // Get a random number between 0 and the length of the word. 
            int next = Random.Range(0, word.Length - 1);    // Take the character from the random position 
            //and add to our char array. 
            chars[index] = word[next];                      // Remove the character from the word. 
            word = word.Substring(0, next) + word.Substring(next + 1);
            ++index;
        }
        return new string(chars);
    }

    private void ScrambleText()
    {
        // if player isn't concentrating enough the letters are scrambled
        if (concentrate.concentration <= 50) ScrambleWord(pressSpaceToBlink.text);

        // else text is normal
        else pressSpaceToBlink.text = "press space to blink";
    }
}
