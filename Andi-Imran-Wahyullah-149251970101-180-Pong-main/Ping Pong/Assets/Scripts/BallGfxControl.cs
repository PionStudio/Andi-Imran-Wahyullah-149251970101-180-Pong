using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallGfxControl : MonoBehaviour
{
    [SerializeField] private GameObject parentObject;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Rigidbody2D parentRb = parentObject.GetComponent<Rigidbody2D>();

        //transform.LookAt(new Vector3(parentRb.velocity.x, 0f, parentRb.velocity.y));
    }
}
