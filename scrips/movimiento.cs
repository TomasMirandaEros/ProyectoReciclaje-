using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movimiento : MonoBehaviour
{
    private new Rigidbody rigidbody;
    public float velocidad;
    // para modificar el valor de la sensebilidad 
    public Vector2 sensebilidadDelMouse;

    void Start()
    {
        rigidbody = GetComponent<Rigidbody>();
    }
    //void del movimiento 
    void UpdateMovement()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        Vector3 direction = (transform.forward * vertical + transform.right * horizontal).normalized;
        Vector3 velocity = direction * velocidad;
        velocity.y = rigidbody.velocity.y;
        rigidbody.velocity = velocity;
    }

    void UpdateMouseLook()
    {
        float horizontal = Input.GetAxis("Mouse X");
        float vertical = Input.GetAxis("Mouse Y");

        if (horizontal != 0)
        {
            transform.Rotate(0, horizontal, 0);
        }

    }


    void Update()
    {
        UpdateMovement();
        UpdateMouseLook();
    }
}
