using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField]
    float speed = 5.0f;
    Vector2 movement;
    Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        //we aren't going to use our update to set the position; instead, we will use it to set up our movement
        movement = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical")).normalized ;  //we want to make sure to normalize our value 


    }

    private void FixedUpdate()
    {
        rb.transform.Translate(movement * Time.fixedDeltaTime * speed);
       // rb.velocity = movement * Time.fixedDeltaTime * speed; //another way to do the same
    }
}
