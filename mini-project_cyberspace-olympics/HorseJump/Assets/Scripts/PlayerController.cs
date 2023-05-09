using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private float moveSpeed = 10f;
    private Rigidbody2D rb;
    private float moveX;
    private Animator animator;
    public ParticleSystem dust;

    // Start is called before the first frame update
    void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        moveX = Input.GetAxis("Horizontal") * moveSpeed;
    }

    void FixedUpdate()
    {
        Vector2 velocity = rb.velocity;
        velocity.x = moveX;
        rb.velocity = velocity;

        if (rb.velocity.y >= 0f)
        {
            animator.SetBool("isInAir", true);
        }
        else
        {
            animator.SetBool("isInAir", false);
        }
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag == "donut")
        {
            other.gameObject.GetComponent<AudioSource>().Play();
        }

        if (other.gameObject.tag == "platform")
        {
            dust.Play();
        }
    }
}
