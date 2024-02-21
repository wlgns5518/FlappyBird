using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerInputController : MonoBehaviour
{
    private Camera _camera;
    private Vector3 movement = new Vector3(0, 1);
    private void Awake()
    {
        _camera = Camera.main;
    }
    public void OnMove()
    {
        //Debug.Log("Move");
        transform.position += movement;
    }
}
