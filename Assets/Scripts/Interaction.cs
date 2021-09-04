using UnityEngine;

public class Interaction : MonoBehaviour
{
    [SerializeField] private float reach;
    [SerializeField] private bool interacting;
    private PlayerController controller;
    private Camera playerCamera;

    private void Start()
    {
        controller = GetComponent<PlayerController>();
        playerCamera = GetComponentInChildren<Camera>();
    }

    // player starts interacting
    public void Start(string n, GameObject g)
    {
        if (Input.GetMouseButtonDown(0) && !interacting)
        {
            // stores info on what ray hits
            RaycastHit hit;

            // the ray is shot from the center of the screen
            Ray ray = playerCamera.ScreenPointToRay(Input.mousePosition);

            // ray is casted out
            if (Physics.Raycast(ray, out hit, reach))
            {
                // if the ray hits a tagged object
                if (hit.collider.name == n)
                {
                    controller.canMove = false;                 // player can't move
                    Cursor.lockState = CursorLockMode.None;     // cursor is free
                    Cursor.visible = true;                      // cursor is visible
                    g.SetActive(true);                          // gameobject is activated
                    interacting = true;                         // bool is true
                }
            } 
        }
    }

    // player stops interacting
    public void Stop(GameObject g)
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            controller.canMove = true;                          // player can move
            Cursor.lockState = CursorLockMode.Locked;           // cursor is locked to center of screen
            Cursor.visible = false;                             // cursor is invisible
            g.SetActive(false);                                 // gameobject is deactivated
            interacting = false;                                // bool is false 
        }
    }
}
