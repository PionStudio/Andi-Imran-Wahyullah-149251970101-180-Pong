using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaddleControl : MonoBehaviour
{
    [SerializeField] private float speed;

    [SerializeField] private KeyCode upKey;
    [SerializeField] private KeyCode downKey;

    private Rigidbody2D myRb;

    // Start is called before the first frame update
    void Start()
    {
        myRb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        Movement(GetInput());
    }

    private Vector2 GetInput()
    {
        Vector2 movement = Vector2.zero;


        if (Input.GetKey(upKey))
        {
            movement = Vector2.up * speed;
        }

        else if (Input.GetKey(downKey))
        {
            movement = Vector2.down * speed;
        }

        return movement; 
    }

    private void Movement(Vector2 move)
    {
        myRb.velocity = move;
    }
}
