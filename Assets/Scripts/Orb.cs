using UnityEngine;



public class Orb : MonoBehaviour
{
    public string orbColor;

    private ScoreManager scoreManager;

    void Start()
    {
        scoreManager = FindObjectOfType<ScoreManager>();
    }
}
