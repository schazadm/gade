using UnityEngine;

public class Platform : MonoBehaviour
{
    public float jumpForce = 10f;
    public PlayerScore playerScore;

    private bool tagged;

    private void Start()
    {
        tagged = false;
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.relativeVelocity.y <= 0f)
        {
            Rigidbody2D rb = collision.gameObject.GetComponent<Rigidbody2D>();
            if (rb != null)
            {
                Vector2 velocity = rb.velocity;
                velocity.y = jumpForce;
                rb.velocity = velocity;
                gameObject.GetComponent<AudioSource>().Play();
                if (!tagged)
                {
                    playerScore.addScore();
                    tagged = true;
                }
            }
        }
    }
}
