using UnityEngine;

public class enemyMovement : MonoBehaviour
{
    [SerializeField] private Rigidbody2D rbE;
    private float speed = 2f;
    void Update()
    {
        MoveEnemy();
    }

    void MoveEnemy()
    {
        float yVel = rbE.linearVelocity.y;

        if (yVel > 0f) yVel *= 0.98f;

        rbE.linearVelocity = new Vector2(-speed, yVel);
    }
}
