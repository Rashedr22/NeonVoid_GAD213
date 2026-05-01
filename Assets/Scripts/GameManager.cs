using UnityEngine;
using TMPro;


public class GameManager : MonoBehaviour
{
    public float timeLeft = 60f;
    public int targetScore = 20;

    public TextMeshProUGUI timerText;
    public TextMeshProUGUI resultText;

    private ScoreManager scoreManager;
    private bool gameEnded = false;
    

    void Start()
    {
        scoreManager = FindObjectOfType<ScoreManager>();
        resultText.gameObject.SetActive(false);
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

        resultText.gameObject.SetActive(true);

        if (totalScore >= targetScore)
        {
            resultText.text = "YOU WIN!";
        }
        else
        {
            resultText.text = "YOU LOSE!";
        }
    }

        public void ShowLose()
    {
        gameEnded = true;
        Time.timeScale = 0f;

        resultText.gameObject.SetActive(true);
        resultText.text = "YOU LOSE!";
    }

}