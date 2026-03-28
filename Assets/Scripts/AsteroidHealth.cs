using UnityEngine;

public class AsteroidHealth : MonoBehaviour
{
    public int health = 1;
    public AudioSource destroySound;

    public void TakeDamage(int damage)
    {
        health -= damage;

        if (health <= 0)
        {
            destroySound.Play();
            Destroy(gameObject, 0.4f);
            
        }
    }
}
