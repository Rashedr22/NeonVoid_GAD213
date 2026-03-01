using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float moveSpeed = 5f;

    private Vector3 movement;

    void Update()
    {
        float moveX = Input.GetAxisRaw("Horizontal");
        float moveY = Input.GetAxisRaw("Vertical");

        movement = new Vector3(moveX, moveY, 0f).normalized;

        transform.position += movement * moveSpeed * Time.deltaTime;
    }
}
