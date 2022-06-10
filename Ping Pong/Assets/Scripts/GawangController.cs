using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GawangController : MonoBehaviour
{
    [SerializeField] private ScoreManager scoreManager;
    [SerializeField] private bool gawangKiri;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Ball"))
        {
            collision.GetComponent<BallControl>().ResetBall();
            scoreManager.CetakGoal(gawangKiri);
        }
    }
}
