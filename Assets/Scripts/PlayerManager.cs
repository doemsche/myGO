﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(PlayerMover))]
[RequireComponent(typeof(PlayerInput))]

public class PlayerManager : MonoBehaviour {

    public PlayerMover playerMover;
    public PlayerInput playerInput;

    void Awake(){
        playerMover = GetComponent<PlayerMover>();
        playerInput = GetComponent<PlayerInput>();
        playerInput.InputEnabled = true;
    }

	void Update () {
        Debug.Log(playerInput.V);
        if(playerMover.isMoving){
            return;
        }

        playerInput.GetKeyInput();
       
        if(playerInput.V == 0){
            
            if(playerInput.H < 0){
                playerMover.MoveLeft();
            }
            else if(playerInput.H > 0){
                playerMover.MoveRight();
            }
        }
        else if(playerInput.H == 0){
            
            if(playerInput.V < 0){
                playerMover.MoveBack();
            }
            else if(playerInput.V > 0){
                playerMover.MoveForward();
            }
        }
	}
}
