using UnityEngine;
/// <summary>
/// This class controls pausing the game.
/// </summary>
public class Pause : MonoBehaviour
{
    [SerializeField] private PlayerController controller;
    [SerializeField] private GameObject pauseMenu;
    [SerializeField] private bool paused = false;

    private void Update()
    {
        // if the tab button is pressed 
        if (Input.GetKeyDown(KeyCode.Tab))
        {
            // if game is not paused
            if (paused == false)
            {
                // pause the game
                PauseGame();
            }
            // else if game is paused
            else if (paused == true)
            {
                // resume the game
                ResumeGame();
            }
        }
    }

    private void PauseGame()
    {
        Time.timeScale = 0f;                        // runtime is frozen
        pauseMenu.SetActive(true);                  // pause menu is enabled
        controller.canMove = false;                 // player can't move
        Cursor.lockState = CursorLockMode.None;     // cursor isn't locked
        Cursor.visible = true;                      // cursor is visible
        paused = true;                              // paused equals true
    }

    public void ResumeGame()
    {
        Time.timeScale = 1f;                        // runtime is normal
        pauseMenu.SetActive(false);                 // pause menu is disabled
        controller.canMove = true;                  // player can move
        Cursor.lockState = CursorLockMode.Locked;   // cursor is locked to center of screen
        Cursor.visible = false;                     // cursor is invisible
        paused = false;                             // paused equals false;
    }
}