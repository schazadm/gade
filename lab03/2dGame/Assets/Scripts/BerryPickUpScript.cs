using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BerryPickUpScript : MonoBehaviour
{
    public LogicManagerScript logicManagerScript;
    public int amountOfScoreToAdd = 5;
    public AudioClip pickUpClip;
    public float volume = 1;
    public RuntimeAnimatorController pickUpAnimator;



    // Start is called before the first frame update
    void Start()
    {
        logicManagerScript = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicManagerScript>();
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.layer == 3)
        {
            logicManagerScript.addScore(amountOfScoreToAdd);
            AudioSource.PlayClipAtPoint(pickUpClip, transform.position, volume);
            GetComponent<Animator>().runtimeAnimatorController = pickUpAnimator;
        }
    }
}
