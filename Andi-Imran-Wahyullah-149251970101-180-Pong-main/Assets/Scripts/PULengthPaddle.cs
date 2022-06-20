using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PULengthPaddle : MonoBehaviour
{
    [SerializeField] private PowerUpManager powerUpManager;
    [SerializeField] private float paddleLength;
    public Collider2D ball;

    [Header("Life Time")]
    [SerializeField] private float lifeTime;
    private float lifeCounter = 0f;

    // Update is called once per frame
    void Update()
    {
        lifeCounter += Time.deltaTime;
        if (lifeCounter >= lifeTime)
        {
            powerUpManager.RemovePowerUp(this.gameObject);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision == ball)
        {
            string paddleName = ball.GetComponent<BallControl>().lastPaddle;

            ball.GetComponent<BallControl>().ActivateLengthPaddle(paddleLength, paddleName);
            powerUpManager.RemovePowerUp(this.gameObject);
        }
    }
}
