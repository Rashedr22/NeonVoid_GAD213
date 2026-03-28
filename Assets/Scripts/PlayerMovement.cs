using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float moveSpeed = 5f;

    public GameObject blueBullet;
    public GameObject redBullet;
    public bool isBlueMode = true;
    public Transform firePoint;
    public float blueFireRate = 0.2f;
    public float redFireRate = 0.1f;
    private float nextFireTime = 0f;
    public AudioSource shootSound;
    

    private Vector3 movement;

    void Update()
    {
        float moveX = Input.GetAxisRaw("Horizontal");
        float moveY = Input.GetAxisRaw("Vertical");

        movement = new Vector3(moveX, moveY, 0f).normalized;

        transform.position += movement * moveSpeed * Time.deltaTime;

       
        if (Input.GetKeyDown(KeyCode.LeftShift))
        {
            isBlueMode = !isBlueMode;
        }

        if (isBlueMode)
        {
            if (Input.GetKeyDown(KeyCode.Space) && Time.time >= nextFireTime)
            {
                Shoot();
                nextFireTime = Time.time + blueFireRate;
            }
        }
        else
        {
            if (Input.GetKey(KeyCode.Space) && Time.time >= nextFireTime)
            {
                Shoot();
                nextFireTime = Time.time + redFireRate;
            }
        }

    }

    void Shoot()
    {
        shootSound.Play();

        if (isBlueMode)
        {
            Instantiate(blueBullet, firePoint.position, Quaternion.identity);
        }
        else
        {
            Instantiate(redBullet, firePoint.position, Quaternion.identity);
        }
    }
}
