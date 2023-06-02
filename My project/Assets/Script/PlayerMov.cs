using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMov : MonoBehaviour
{
    


        public float moveSpeed = 5f;
        public float runSpeed = 10f;
        public float jumpForce = 5f;
        public Transform cameraTransform;

        private Rigidbody rb;
       

        private void Start()
        {
            rb = GetComponent<Rigidbody>();
            Cursor.lockState = CursorLockMode.Locked; // Blocca il cursore al centro dello schermo
        }

        private void Update()
        {
            // Movimento orizzontale e verticale
            float moveHorizontal = Input.GetAxis("Horizontal");
            float moveVertical = Input.GetAxis("Vertical");

            // Spostamento
            Vector3 movement = transform.right * moveHorizontal + transform.forward * moveVertical;
            movement.y = rb.velocity.y;

            //Corsa
          

            ////Salto
            //if (Input.GetButtonDown("Jump") && !isJumping)
            //{
            //    rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
            //    isJumping = true;
            //}

            //Movimento della visuale in prima persona
            float mouseX = Input.GetAxis("Mouse X");
            float mouseY = Input.GetAxis("Mouse Y");

            transform.Rotate(Vector3.up * mouseX);
            cameraTransform.Rotate(Vector3.left * mouseY);

            // Sblocca il cursore premendo il tasto ESC
            if (Input.GetKeyDown(KeyCode.Escape))
            {
                Cursor.lockState = CursorLockMode.None;
            }
        }


    }


