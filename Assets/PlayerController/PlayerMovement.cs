using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    Rigidbody2D playerRigidbody;


    private Vector2 velocity;
    //My player 
    Vector2 playerVector; 
    //Speed so we can go fast
    public float Speed = 2.0f;
    private void Awake()
    {
        //Getting my component and putting it in playerInput
        playerRigidbody = GetComponent<Rigidbody2D>();

        //adding my update move vector mwthod to my MoveEvent action
        PlayerInputActions.MoveEvent += UpdateMoveVector;
    }
    // Start is called before the first frame update
    void Start()
    {
        velocity = new Vector2(1.75f, 1.1f);
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        
        //Updating my movement with my moveVector
        Movement();
    }
    void Movement()
    {
        //Making my player vector motion my Movement vector 
        playerRigidbody.MovePosition(playerRigidbody.position + playerVector  * Time.fixedDeltaTime * Speed);
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
