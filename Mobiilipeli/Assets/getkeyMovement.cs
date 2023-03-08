using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class getkeyMovement : MonoBehaviour
{
    [SerializeField]
    private float speed = 5f;

    [SerializeField]
    private float rotationSpeed;

    // Update is called once per frame
    private void Update()
    {
        /*float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");    

        Vector2 movementDirection = new Vector2(horizontalInput, verticalInput);
        float inputMagnitude = Mathf.Clamp01(movementDirection.magnitude);
        movementDirection.Normalize();

        if (movementDirection != Vector2.zero)
        {
            Quaternion toRotation = Quaternion.LookRotation(Vector3.forward, movementDirection);
            transform.rotation = Quaternion.RotateTowards(transform.rotation, toRotation, rotationSpeed * Time.deltaTime);
        }*/

        float moveX = 0f;
        float moveY = 0f;       

        //moveX++;

        if (Input.GetKey(KeyCode.W))
        {
            moveY = 1f;
        }

        /*if (Input.GetKey(KeyCode.S))
        {
            moveY = -1f;
        }*/

        if (Input.GetKey(KeyCode.A))
        {
            moveX = 0.5f;
            moveY = 1f;   
        }

        if (Input.GetKey(KeyCode.D))
        {
            moveX = -0.5f;
            moveY = 1f;
        }

        Vector3 moveDir = new Vector3(moveX, moveY);
        transform.position += moveDir * speed * Time.deltaTime;
    }
}
