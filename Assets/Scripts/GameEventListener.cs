using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
public class GameEventListener : MonoBehaviour
{
    public GameEvent Event;
    public UnityEvent Response;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void OnEnable()
    {
        Event.RegisterListener(this);
    }
    public void OnDisable()
    {

        Event.UnregisterListener(this);
    }
    public void OnEventRaised()
    {
        Response.Invoke();
    }
}
