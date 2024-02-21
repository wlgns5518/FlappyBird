using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UIElements;

public class PlayerInputController : MonoBehaviour
{
    private Camera _camera;
    private Vector3 movement = new Vector3(0, 1);
    private float speed = 5;
    private void Awake()
    {
        _camera = Camera.main;
    }
    public void OnMove()
    {
        //Debug.Log("Move");
        StartCoroutine(Movement(transform));
    }

    IEnumerator Movement(Transform transform)
    {
        float t = 0;
        Vector3 s = transform.position;
        Vector3 e = transform.position + movement;
        while (t*speed < 1)
        {
            t +=Time.deltaTime;
            transform.position = Vector3.Lerp(s,e,t*speed);
            yield return null;
        }    }
}
