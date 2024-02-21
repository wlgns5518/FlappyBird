using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerInputController : CharacterController
{
    private Camera _camera;

    private void Awake()
    {
        _camera = Camera.main;
    }
    public void OnMove()
    {
        //Debug.Log("Move");
        CallMoveEvnet();
    }
}
