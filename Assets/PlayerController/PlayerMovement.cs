using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    CharacterController playerInput;

    public static GameObject HeldItem;
    //My player 
    Vector2 playerVector; 
    //Speed so we can go fast
    float Speed = 2.0f;
    private void Awake()
    {
        //Getting my component and putting it in playerInput
        playerInput = GetComponent<CharacterController>();

        //adding my update move vector mwthod to my MoveEvent action
        PlayerInputActions.MoveEvent += UpdateMoveVector;
    }
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //Updating my movement with my moveVector
        Movement(playerVector);
    }
    void Movement(Vector2 inputMovement)
    {
        //Making my player vector motion my Movement vector 
        playerInput.Move(Speed * Time.deltaTime * inputMovement);
    }
    void UpdateMoveVector(Vector2 inputMovement)
    {
        //Making my moveVector equal to Movement 
        playerVector = inputMovement;
    }
    private void OnDisable()
    {
        //Unsubscribing my MoveEvent from UpdateMoveVector
        PlayerInputActions.MoveEvent -= UpdateMoveVector;
    }
}
