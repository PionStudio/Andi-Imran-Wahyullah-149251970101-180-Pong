using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallControl : MonoBehaviour
{
    private Rigidbody2D myRb;

    [SerializeField] private float ballSpeed;
    [SerializeField] private float yMin;
    [SerializeField] private float yMax;

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
}
