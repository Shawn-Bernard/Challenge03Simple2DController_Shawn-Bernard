using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public CharacterController playerInput;
    Vector3 moveDirection; 
    public float Speed = 2.0f;
    //CharacterController
    private void Awake()
    {
        PlayerInputActions.MoveEvent += Move;
    }
    // Start is called before the first frame update
    void Start()
    {
        playerInput = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        Move();
    }
    void Move()
    {
        playerInput.Move(moveDirection * Time.deltaTime);
    }
    private void OnEnable()
    {

    }
    private void OnDisable()
    {
        
    }
}
