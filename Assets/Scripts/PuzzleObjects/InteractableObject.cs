using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
public class InteractableObject : MonoBehaviour
{

    /// <summary>
    /// Our interactable object has the following requirements:
    /// 1. They have to be able to be either enabled or disabled
    /// 2. They have to broadcast when they are enabled or disabled
    /// 3. They also need to have a state for enabled/disabled
    /// 
    /// </summary>
    // Start is called before the first frame update

    public InteractableObjectState CurrentState
    {
        get
        {
            return _currentState;
        }
        set
        {
            _currentState = value;
        }
    }
    InteractableObjectState _currentState;
    [SerializeField]
    UnityEvent stateChanged;

    [SerializeField]
    UnityEvent interactionEvent;

    void Start()
    {
        this.GetComponent<GameEventListener>().OnDisable();
    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("There is a trigger collider over top of us");
        if (collision.gameObject.GetComponent<Flashlight>())
            this.GetComponent<GameEventListener>().OnEnable();
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        Debug.Log("There is a trigger collider over top of us");
        if (collision.gameObject.GetComponent<Flashlight>())
            this.GetComponent<GameEventListener>().OnDisable();
    }
    public void InteractedWith()
    {
        Debug.Log("We were interacted with");
    }
}
public enum InteractableObjectState
{
    Enabled,
    Disabled
}
