using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveStraightContoller : MonoBehaviour
{
    // Start is called before the first frame update

    public Vector2 velocity;
    Rigidbody2D body;

    void Start()
    {
        body = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        body.velocity = velocity;
    }
}
