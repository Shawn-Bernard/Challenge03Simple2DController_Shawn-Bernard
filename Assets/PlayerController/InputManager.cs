using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.InputSystem;
using System;

public class InputManager : MonoBehaviour, PlayerInput.IPlayerActions
{
    PlayerInput PlayerInput;
    private void Awake()
    {
        //Making a new instance of gameinput
        PlayerInput = new PlayerInput();
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
        if (context.performed)
        {
            Debug.Log($"Move input: {context.ReadValue<Vector2>()}");
            PlayerInputActions.MoveEvent.Invoke(context.ReadValue<Vector2>);
        }
        
    }
    
}
public static class PlayerInputActions
{
    public static Action<Vector2> MoveEvent;
}
