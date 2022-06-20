using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallControl : MonoBehaviour
{
    private Rigidbody2D myRb;

    [SerializeField] private float ballSpeed;
    [SerializeField] private float yMin;
    [SerializeField] private float yMax;

    public string lastPaddle;

    private void Start()
    {
        myRb = GetComponent<Rigidbody2D>();

        //Force acak diawal
        float yAxis = Random.Range(yMin, yMax);

        myRb.velocity = new Vector2(1, yAxis) * ballSpeed;
    }

    private void Update()
    {

    }

    public void ResetBall()
    {
        transform.position = Vector3.zero;
        myRb.velocity = new Vector2(1, Random.Range(yMin, yMax)) * ballSpeed;
    }

    public void ActivatePUSpeedUp(float magnitude)
    {
        myRb.velocity *= magnitude;
    }

    public void ActivateLengthPaddle(float lenght, string paddleName)
    {
        GameObject paddle = GameObject.Find(paddleName);
        paddle.GetComponent<PaddleControl>().LengthenPaddle(lenght);
    }

    public void ActivateSpeedPaddle(float speed, string paddleName)
    {
        GameObject paddle = GameObject.Find(paddleName);
        paddle.GetComponent<PaddleControl>().SpeedPaddle(speed);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name == "Paddle Kiri")
        {
            lastPaddle = "Paddle Kiri";
        }

        if (collision.gameObject.name == "Paddle Kanan")
        {
            lastPaddle = "Paddle Kanan";
        }
    }
}
