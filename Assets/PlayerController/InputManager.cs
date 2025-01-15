using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.InputSystem;
using System;

public class InputManager : MonoBehaviour, PlayerController.IPlayerActions
{
    PlayerController PlayerInput;
    private void Awake()
    {
        //Making a new instance of gameinput
        PlayerInput = new PlayerController();
        //Enable my new instance of gameinput
        PlayerInput.Player.Enable();

        PlayerInput.Player.SetCallbacks(this);
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void OnMove(InputAction.CallbackContext context)
    {

    }
    
}
public static class InputActions
{
    public static Action<Vector2> MoveEvent;
}
