using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Flashlight : MonoBehaviour
{
    public UnityEvent interact; 
    [SerializeField]
    GameEvent triggerEvent;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        Vector2 mouseDirection = (mousePos - (Vector2)transform.position).normalized;
        transform.up = mouseDirection;
        if (Input.GetButtonDown("Jump"))
        {
            triggerEvent.Raise();
        }
    }
}
