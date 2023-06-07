using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUppable : Interactable
{
    private Inventory inventory;

    void Awake()
    {
        inventory = GameObject.Find("Player 1").GetComponent<Inventory>();    
    }
    protected override void Interact()
    {
        inventory.addItem(gameObject);
        Destroy(gameObject);
    }
}
