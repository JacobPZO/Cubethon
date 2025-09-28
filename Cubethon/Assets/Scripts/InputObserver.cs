using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class InputObserver : MonoBehaviour
{
    [SerializeField] private PlayerSubject subjectToObserve;

    private int playerInputs = 0;
    private int leftInputs = 0;
    private int rightInputs = 0;

    private void OnPlayerInput()
    {
        playerInputs++;

    }
    private void OnLeftInput()
    {
        leftInputs++;

    }
    private void OnRightInput()
    {
        rightInputs++;

    }

    private void Awake()
    {
        if (subjectToObserve != null) 
        {
            subjectToObserve.PlayerInput += OnPlayerInput;
            subjectToObserve.LeftInput += OnLeftInput;
            subjectToObserve.RightInput += OnRightInput;
        }
    }

    private void OnDestroy()
    {
        if (subjectToObserve != null) 
        {
            subjectToObserve.PlayerInput -= OnPlayerInput;
            subjectToObserve.LeftInput -= OnLeftInput;
            subjectToObserve.RightInput -= OnRightInput;
        }
    }

    void OnGUI() {
            GUILayout.BeginArea (
                new Rect (50,50,100,200));
           
            GUILayout.BeginHorizontal ("box");
            GUILayout.Label ("total: " + playerInputs);
            GUILayout.EndHorizontal ();

            GUILayout.BeginHorizontal ("box");
            GUILayout.Label ("left: " + leftInputs);
            GUILayout.EndHorizontal ();

            GUILayout.BeginHorizontal ("box");
            GUILayout.Label ("right: " + rightInputs);
            GUILayout.EndHorizontal ();
            
            GUILayout.EndArea ();
        }

}
