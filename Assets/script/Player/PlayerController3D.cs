using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController3D : MonoBehaviour
{
    public float speed = 25f; // Velocidad
    public float speedJump = 30f; // velocidad de salto
    private Rigidbody playerb;  // rigidbody
    private Vector3 moveInput; //el imput 3D
    // Start is called before the first frame update
    void Start()
    {
        playerb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        float moveX = Input.GetAxisRaw("Horizontal"); //movimiento horizontal
        float moveZ = Input.GetAxisRaw("Vertical"); //movimiento vertical
        moveInput = new Vector3(moveX, 0, moveZ); //asignandole donde va cada movimiento
        if (Input.GetKeyDown("space") && playerb.velocity.y == 0)
        {
            playerb.AddForce(transform.up * speedJump);
            Debug.Log("ñiñi");
        }// cuando apretas ek espacio y la velocidad hacia arriba es cero, añadimos una fuerza hacia arriba multiplicando por la velocidad de salto, esto nos permite saltaraz

    }
    private void FixedUpdate()
    {
        playerb.MovePosition(playerb.position + moveInput.normalized * speed * Time.fixedDeltaTime); //movimiento fluido
    }
}
