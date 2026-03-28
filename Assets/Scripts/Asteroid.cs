using UnityEngine;

public class Asteroid : MonoBehaviour
{
    float fallSpeed;

    void Start()
    {
        fallSpeed = Random.Range(2f, 4f);
    }

    void Update()
    {
        transform.position += Vector3.down * fallSpeed * Time.deltaTime;
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            other.GetComponent<PlayerLife>().TakeDamage();
            Destroy(gameObject);
        }
    }


}
