using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Events;

public class InteractObject : MonoBehaviour
{
    public GameObject DisplayText;
    public UnityEvent OnInteract;

    public string GetInteractionText()
    {
        if (DisplayText.activeSelf)
        {
            return "Press E to hide";
        }
        else
        {
            return "Press E to show";
        }
    }

    public void Interact()
    {
        // Toggle the active state of DisplayText
        DisplayText.SetActive(!DisplayText.activeSelf);
    }
}
