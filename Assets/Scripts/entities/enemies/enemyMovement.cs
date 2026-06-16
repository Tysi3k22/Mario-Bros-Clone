using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    [SerializeField] private GameObject player;
    [SerializeField] private Rigidbody2D rb;

    [SerializeField] private float speed = 2f;

    private void FixedUpdate()
    {
        MoveEnemy();
    }

    private void MoveEnemy()
    {
        rb.linearVelocity = new Vector2(-speed, rb.linearVelocity.y);

        if (rb.position.y < -4f)
        {
            Destroy(gameObject);
            return;
        }

        if (player != null &&
            rb.position.x < player.transform.position.x - 5f)
        {
            Destroy(gameObject);
        }
    }
}