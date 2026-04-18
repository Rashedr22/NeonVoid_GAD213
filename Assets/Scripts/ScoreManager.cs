using UnityEngine;
using TMPro;
public class ScoreManager : MonoBehaviour
{
    public int blueScore = 0;
    public int redScore = 0;

    public TextMeshProUGUI blueText;
    public TextMeshProUGUI redText;

    void Start()
    {
        UpdateUI();
    }

    public void AddBlueScore(int amount)
    {
        blueScore += amount;
        UpdateUI();
    }

    public void AddRedScore(int amount)
    {
        redScore += amount;
        UpdateUI();
    }

    void UpdateUI()
    {
        blueText.text = "B  : " + blueScore;
        redText.text = "R  : " + redScore;
    }
}
