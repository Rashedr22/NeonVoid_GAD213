using UnityEngine;
using System.Collections;

public class PlayerLife : MonoBehaviour
{
    public int lives = 3;
    public GameObject[] lifeIcons;
    public AudioSource deathSound;
    public void TakeDamage()
    {
        lives--;

        lifeIcons[lives].SetActive(false);

        deathSound.Play();

        if (lives <= 0)
        {
            Time.timeScale = 0f;
            Debug.Log("GAME OVER");
            return;
        }

        Time.timeScale = 0f;
        StartCoroutine(ResumeAfterDelay());

    }

    IEnumerator ResumeAfterDelay()
    {
        yield return new WaitForSecondsRealtime(1f);
        Time.timeScale = 1f;
    }

    void ResumeGame()
    {
        Time.timeScale = 1f;
    }
}
