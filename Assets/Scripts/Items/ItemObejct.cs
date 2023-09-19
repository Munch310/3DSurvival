using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemObejct : MonoBehaviour, IInteractable
{
    public ItemData item;

    public string GetIneractPrompt()
    {
        return string.Format("Pickup {0}", item.displayName);
    }

    public void OnInteract()
    {
        Destroy(gameObject);
    }
}
