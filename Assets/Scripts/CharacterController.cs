using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterController : MonoBehaviour
{
    public event Action<Vector2> OnMoveEvnet;
    private Vector2 movement = new Vector2(0, 1);

    public void CallMoveEvnet() 
    { 
        OnMoveEvnet?.Invoke(movement);
    }

}
