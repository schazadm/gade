using UnityEngine;

public class MovePlatform : MonoBehaviour
{
    public float speed;
    private Vector2 rightEndPosition;
    private Vector2 leftEndPosition;
    private bool moveRight;

    private void Start()
    {
        rightEndPosition = new Vector2(4f, transform.position.y);
        leftEndPosition = new Vector2(-5.5f, transform.position.y);
        moveRight = true;
    }

    private void FixedUpdate()
    {
        if (moveRight)
        {
            transform.position = Vector2.MoveTowards(transform.position, rightEndPosition, speed * Time.deltaTime);
        }
        else
        {
            transform.position = Vector2.MoveTowards(transform.position, leftEndPosition, speed * Time.deltaTime);
        }

        if (transform.position.x >= rightEndPosition.x)
        {
            moveRight = false;
        }

        if (transform.position.x <= leftEndPosition.x)
        {
            moveRight = true;
        }
    }
}
