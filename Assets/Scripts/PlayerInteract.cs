using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class PlayerInteract : MonoBehaviour
{
    public Camera PlayerCamera;
    public float InteractionDistance = 3f;
    public GameObject InteractionText;
    private InteractObject currentInteractable;

    // Update is called once per frame
    void Update()
    {
        Ray ray = new Ray(PlayerCamera.transform.position, PlayerCamera.transform.forward);
        RaycastHit hit;

        if (Physics.Raycast(ray, out hit, InteractionDistance))
        {
            InteractObject interactable = hit.collider.GetComponent<InteractObject>();
            if (interactable != null)
            {
                if (interactable != currentInteractable)
                {
                    currentInteractable = interactable;
                    InteractionText.SetActive(true);
                }

                InteractionText.GetComponent<TextMeshProUGUI>().text = currentInteractable.GetInteractionText();
            }
        }
        else
        {
            // Not looking at any object
            currentInteractable = null;
            InteractionText.SetActive(false);
        }

        if (Input.GetKeyDown(KeyCode.E) && currentInteractable != null)
        {
            currentInteractable.Interact();
        }
    }
}
