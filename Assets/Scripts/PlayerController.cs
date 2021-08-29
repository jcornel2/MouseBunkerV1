using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public Vector2 speed = new Vector2(50, 50);
    public Rigidbody2D rb2d;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float inputX = Input.GetAxis("Horizontal");

        Vector2 vel = rb2d.velocity;
        vel.x = speed.x * inputX;

        //vel *= Time.deltaTime;

        rb2d.velocity = vel;

        //transform.Translate(movement);
    }
}
