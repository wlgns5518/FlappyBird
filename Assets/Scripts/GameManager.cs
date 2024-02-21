using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public bool playerDie = false;
    [SerializeField] private GameObject player;
    private float obstacleTime = 3f;
    private float obstacleMin = -4f;
    private float obstacleMax = 3f;

    [SerializeField] private GameObject obstaclePrefab;

    public int score = 0;
    public TextMeshProUGUI scoreText;
    public GameObject endPannel;
    public static GameManager instance;
    private void Awake()
    {
        instance = this;
    }
    // Start is called before the first frame update
    private void Start()
    {
        StartCoroutine("ObstacleStart");
    }

    IEnumerator ObstacleStart()
    {
        do
        {
            Instantiate(obstaclePrefab,
                new Vector3(13,Random.Range(obstacleMin,obstacleMax),0),
                Quaternion.identity);
            yield return new WaitForSeconds(obstacleTime);
        }while(!playerDie);

    }

    public void PlayerDie()
    {
        playerDie = true;
        endPannel.SetActive(true);
    }
    public void RetryButton()
    {
        SceneManager.LoadScene("MainScene");
    }
    public void HomeButton()
    {
        SceneManager.LoadScene("HomeScene");
    }
    public void ScoreUpdate()
    {
        scoreText.text = score.ToString();
    }
}
