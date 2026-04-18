using UnityEngine;
using TMPro;


public class GameManager : MonoBehaviour
{
    public float timeLeft = 60f;
    public int targetScore = 20;

    public TextMeshProUGUI timerText; // ✅ MOVE IT HERE

    private ScoreManager scoreManager;
    private bool gameEnded = false;

    void Start()
    {
        scoreManager = FindObjectOfType<ScoreManager>();
    }

    void Update()
    {
        if (gameEnded) return;

        timeLeft -= Time.deltaTime;

        timerText.text = " " + Mathf.Ceil(timeLeft).ToString();

        if (timeLeft <= 0)
        {
            EndGame();
        }
    }

    void EndGame()
    {
        gameEnded = true;
        Time.timeScale = 0f;

        int totalScore = scoreManager.blueScore + scoreManager.redScore;

        if (totalScore >= targetScore)
        {
            Debug.Log("YOU WIN!");
        }
        else
        {
            Debug.Log("YOU LOSE!");
        }
    }
}