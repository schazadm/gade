using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdScript : MonoBehaviour
{
    public Rigidbody2D birdRigidBody;
    public AudioClip clip;
    public LogicManagerScript logicManagerScript;
    public float flapStrenght = 10;
    public float volume = 1;
    public bool birdIsAlive = true;
    public RuntimeAnimatorController newAnimator;
    public AudioClip gameOverClip;


    // Start is called before the first frame update
    void Start()
    {
        logicManagerScript = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicManagerScript>();

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && birdIsAlive)
        {
            birdRigidBody.velocity = Vector2.up * flapStrenght;
            AudioSource.PlayClipAtPoint(clip, transform.position, volume);
        }
    }

    void OnCollisionEnter2D(Collision2D other)
    {
        birdIsAlive = false;
        GetComponent<Animator>().runtimeAnimatorController = newAnimator;
        AudioSource.PlayClipAtPoint(gameOverClip, transform.position, volume);
        GameObject.Find("Background").GetComponent<AudioSource>().Pause();
        logicManagerScript.gameOver();
    }
}
