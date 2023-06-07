using JetBrains.Rider.Unity.Editor;
using System.Collections;
using System.Collections.Generic;
using UnityEditor.SceneManagement;
using UnityEngine;

public class FlashLightInteract : Interactable
{
    public Transform handTransform;
    public Rigidbody body;
    public bool torciaInMano = false;
    private InputManager inputManager;

    private void Start()
    {
        body = GetComponent<Rigidbody>();
    }
    protected override void Interact()
    {
        Destroy(body);
        transform.SetParent(handTransform);
        transform.localPosition = Vector3.zero;
        transform.localRotation = Quaternion.identity;

        inputManager = GetComponent<InputManager>();
        inputManager.flashlight = GetComponent<FlashlightToggle>();
 
        torciaInMano = true;
    }

    //private void 
}
