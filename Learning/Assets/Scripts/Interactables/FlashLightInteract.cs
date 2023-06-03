using JetBrains.Rider.Unity.Editor;
using System.Collections;
using System.Collections.Generic;
using UnityEditor.SceneManagement;
using UnityEngine;

public class FlashLightInteract : Interactable
{
    public Transform handTransform;
    public Rigidbody rb;
    //private bool torciaInMano = false;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }
    protected override void Interact()
    {
        transform.SetParent(handTransform);
        transform.localPosition = Vector3.zero;
        transform.localRotation = Quaternion.identity;
        Destroy(rb);
        //torciaInMano = true;
    }
}
