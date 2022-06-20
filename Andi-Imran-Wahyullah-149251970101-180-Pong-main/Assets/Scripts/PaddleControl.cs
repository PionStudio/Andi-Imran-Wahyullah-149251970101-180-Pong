using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaddleControl : MonoBehaviour
{
    [SerializeField] private float speed;

    [SerializeField] private KeyCode upKey;
    [SerializeField] private KeyCode downKey;

    private Rigidbody2D myRb;

    [Header("Lenghthen PowerUp")]
    [SerializeField] private float lengthenPUTimer;
    private float lengthenPUCounter = 0f;
    private Vector3 initialLenth;
    private bool lenghtenPUActive = false;

    [Header("Speed PowerUp")]
    [SerializeField] private float speedPUTimer;
    private float speedPUCounter = 0f;
    private float initialSpeed;
    private bool speedPUActive = false;

    // Start is called before the first frame update
    void Start()
    {
        myRb = GetComponent<Rigidbody2D>();

        initialLenth = gameObject.transform.localScale;
        initialSpeed = speed;
    }

    // Update is called once per frame
    void Update()
    {
        Movement(GetInput());

        LengthenPaddleCounter();
        SpeedPaddleCounter();
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
        Debug.Log("Kecepatan Paddle = " + move.ToString());
    }

    public void LengthenPaddle(float lenght)
    {
        gameObject.transform.localScale = new Vector3(gameObject.transform.localScale.x, lenght, gameObject.transform.localScale.z);
        lenghtenPUActive = true;
    }

    private void LengthenPaddleCounter()
    {
        if (lenghtenPUActive)
        {
            lengthenPUCounter += Time.deltaTime;

            if (lengthenPUCounter >= lengthenPUTimer)
            {
                lengthenPUCounter = 0f;
                gameObject.transform.localScale = initialLenth;
                lenghtenPUActive = false;
            }
        }
    }

    public void SpeedPaddle(float speed)
    {
        this.speed = speed;
        speedPUActive = true;
    }

    private void SpeedPaddleCounter()
    {
        if (speedPUActive)
        {
            speedPUCounter += Time.deltaTime;

            if (speedPUCounter >= speedPUTimer)
            {
                speedPUCounter = 0f;
                gameObject.transform.localScale = initialLenth;
                speedPUActive = false;
            }
        }
    }
}
