using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoBehaviour
{
    // This script runs all functionalities

    InputManager inputManager;
    PlayerLocomotion playerLocomotion;

    private void Awake()
    {
        inputManager = GetComponent<InputManager>();    
        playerLocomotion = GetComponent<PlayerLocomotion>();
    }

    private void Update()
    {
        inputManager.HandleAllInputs();
    }

    //When working with movement (rigidbody), use FixedUpdate
    private void FixedUpdate()
    {
        playerLocomotion.HandleAllMovement();
    }

}
