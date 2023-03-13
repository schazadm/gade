using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformMiddleScript : MonoBehaviour
{
    public LogicManagerScript logicManagerScript;

    // Start is called before the first frame update
    void Start()
    {
        logicManagerScript = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicManagerScript>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.layer == 3)
        {
            logicManagerScript.addScore(1);
        }
    }
}
