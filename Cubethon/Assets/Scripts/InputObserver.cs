using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class InputObserver : MonoBehaviour
{
    [SerializeField] private PlayerSubject subjectToObserve;

    private int playerInputs = 0;

    private void OnPlayerInput()
    {
        playerInputs++;

    }

    private void Awake()
    {
        if (subjectToObserve != null) 
        {
            subjectToObserve.PlayerInput += OnPlayerInput;
        }
    }

    private void OnDestroy()
    {
        if (subjectToObserve != null) 
        {
            subjectToObserve.PlayerInput -= OnPlayerInput;
        }
    }

    void OnGUI() {
            GUILayout.BeginArea (
                new Rect (50,50,100,200));
           
            GUILayout.BeginHorizontal ("box");
            GUILayout.Label ("inputs: " + playerInputs);
            GUILayout.EndHorizontal ();
            
            GUILayout.EndArea ();
        }

}
