using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Rigidbody2D rb2d;
    public float speed = 10f;

    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        // Simple WASD movement system
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        Vector2 movement = new Vector2(moveHorizontal, moveVertical);
        rb2d.AddForce(movement * speed);
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("Collision detected");
    }

    void OnCollisionExit2D(Collision2D collision)
    {
        Debug.Log("Collision ended");
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log("Trigger detected");
    }

    void OnTriggerExit2D(Collider2D other)
    {
        Debug.Log("Trigger ended");
    }
}

