using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PUSpeedUp : MonoBehaviour
{
    [SerializeField] private PowerUpManager powerUpManager;
    public Collider2D ball;
    [SerializeField] private float magnitude;

    [Header("Life Time")]
    [SerializeField] private float lifeTime;
    private float lifeCounter = 0f;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision == ball)
        {
            ball.GetComponent<BallControl>().ActivatePUSpeedUp(magnitude);
            powerUpManager.RemovePowerUp(this.gameObject);
        }
    }

    private void Update()
    {
        lifeCounter += Time.deltaTime;
        if (lifeCounter >= lifeTime)
        {
            powerUpManager.RemovePowerUp(this.gameObject);
        }
    }
}
