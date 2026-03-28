using UnityEngine;

public class OrbMovement : MonoBehaviour
{
    public float fallSpeed = 2f;

    void Update()
    {
        transform.Translate(Vector2.down * fallSpeed * Time.deltaTime);
    }
}
