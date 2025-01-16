using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class PlayerMovement : MonoBehaviour
{
    CharacterController playerInput;

    public GameObject fish;
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
    private void Fish()
    {
        fish.SetActive(false);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (gameObject.CompareTag("Fish"))
        {
            PlayerInputActions.InteractEvent += Fish;
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (gameObject.CompareTag("Fish"))
        {
            PlayerInputActions.InteractEvent -= Fish;
        }
    }
    private void OnDisable()
    {
        //Unsubscribing my MoveEvent from UpdateMoveVector
        PlayerInputActions.MoveEvent -= UpdateMoveVector;
    }
}
