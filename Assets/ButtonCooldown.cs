using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class ButtonCooldown : MonoBehaviour
{
    // private void Start()
    // {
    //     StartCoroutine(EnableButtonAfterDelay(10f));
    // }

    private IEnumerator EnableButtonAfterDelay(float delay)
    {
        yield return new WaitForSeconds(delay);
        GetComponent<Button>().interactable = true;
    }

    public void OnClick()
    {
        // Check if the button is interactable
        if (GetComponent<Button>().interactable)
        {
            // Call your desired button functionality here
            Debug.Log("Button pressed!");

            // Disable the button to prevent immediate multiple presses
            GetComponent<Button>().interactable = false;

            // Start the coroutine to enable the button after 10 seconds
            StartCoroutine(EnableButtonAfterDelay(10f));
        }
    }
}
