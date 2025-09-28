using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class PlayerSubject : MonoBehaviour
{
    public event Action PlayerInput;

    public void InputCount()
    { 
        PlayerInput?.Invoke();
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if(Input.GetKey("d") || Input.GetKey("a")) 
        {
            InputCount();
        }
    }
}
