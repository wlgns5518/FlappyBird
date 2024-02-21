using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleMove : MonoBehaviour
{
    [SerializeField] private float obstacleSpeed = 4f;
    GameManager gameManager;
    private void Start()
    {
        gameManager = GameManager.instance;
    }
    // Update is called once per frame
    private void Update()
    {
        if(gameManager.playerDie == false)
        {
            transform.position += new Vector3(-obstacleSpeed * Time.deltaTime, 0, 0);
            if(transform.position.x <-13)
            {
                Destroy(gameObject);
            }
        }
        
    }
}
