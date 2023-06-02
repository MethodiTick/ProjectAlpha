using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Interactable: MonoBehaviour
{
    //message displayed to player when looking at interactable
    public string promptMessage;
    
    //function called by the player
    public void BaseInteract()
    {
        Interact();
    }
    
    protected virtual void Interact()
    {
        //to be overwritten
    }
}
