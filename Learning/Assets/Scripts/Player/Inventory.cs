using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    private GameObject[] oggetti = new GameObject[1];

    public void addItem(GameObject o)
    {
        oggetti[0] = o;
        Debug.Log(oggetti[0]);
    }
}
