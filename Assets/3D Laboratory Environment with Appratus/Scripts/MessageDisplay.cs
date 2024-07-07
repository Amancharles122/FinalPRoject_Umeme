using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MessageDisplay : MonoBehaviour
{
    public Text messageText; // Reference to the UI Text element

    void Start()
    {
        // Ensure the message text is initially hidden
        messageText.gameObject.SetActive(false);
    }

    void Update()
    {
        // Check for touch or click input
        if (Input.GetMouseButtonDown(0)) // Change 0 to the correct button index if needed
        {
            // Cast a ray from the screen into the scene
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            // Check if the ray hits any game object
            if (Physics.Raycast(ray, out hit))
            {
                // Example: Display message when specific object is clicked
                if (hit.collider.CompareTag("ErrorTAg")) // Replace "YourTag" with your object's tag
                {
                    DisplayMessage("You touched/clicked the object!");
                }
            }
        }
    }

    void DisplayMessage(string message)
    {
        messageText.gameObject.SetActive(true);
        messageText.text = message;

        // Optionally, hide the message after a delay
        Invoke("HideMessage", 3f); // Adjust the delay time as needed
    }

    void HideMessage()
    {
        messageText.gameObject.SetActive(false);
    }
}

