using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float speed = 12f;
    public int damage = 1;
    public string bulletColor;
   
    void Update()
    {
        transform.Translate(Vector2.up * speed * Time.deltaTime);
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        // Asteroid 
        AsteroidHealth asteroid = other.GetComponent<AsteroidHealth>();

        if (asteroid != null)
        {
            asteroid.TakeDamage(damage);
            Destroy(gameObject);
            return;
        }

        // Orb system
        Orb orb = other.GetComponent<Orb>();

        if (orb != null)
        {
            if (orb.orbColor == bulletColor)
            {
                // ADD SCORE HERE
                ScoreManager sm = FindObjectOfType<ScoreManager>();

                if (bulletColor == "Blue")
                {
                    sm.AddBlueScore(1);
                }
                else if (bulletColor == "Red")
                {
                    sm.AddRedScore(1);
                }

                Destroy(orb.gameObject); // correct color
            }

            Destroy(gameObject); // bullet always gone
        }
    }

    void OnBecameInvisible()
    {
        Destroy(gameObject);
    }
}
