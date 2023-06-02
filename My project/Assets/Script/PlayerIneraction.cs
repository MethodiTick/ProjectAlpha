using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerIneraction : MonoBehaviour
{
    
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            float interactRange = 2f;
            Collider[] colliderArray = Physics.OverlapSphere(transform.position, interactRange);
            foreach (Collider co in colliderArray)
            {
                if(co.TryGetComponent(out NpcInteract npcInteractable)){
                    npcInteractable.Interact();
                }
            }
        }
    }
        
}
