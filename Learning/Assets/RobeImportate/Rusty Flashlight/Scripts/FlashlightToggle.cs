using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Experimental.GlobalIllumination;

public class FlashlightToggle : MonoBehaviour
{
    public GameObject lightGO; //light gameObject to work with
    private bool isOn = false; //is flashlight on or off?

    // Use this for initialization
    void Start()
    {
        //set default off
        lightGO.SetActive(isOn);
    }

    public void lightOnOff()
    {
        if(isOn)
        {
            isOn = !isOn;
            lightGO.SetActive(false);
        }
        else
        {
            isOn = !isOn;
            lightGO.SetActive(true);
        }
    }
}
