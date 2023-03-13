using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BerryMoveScript : MonoBehaviour
{
    public float moveSpeed = 5;
    public float deadZone = -12;

    // Update is called once per frame
    void Update()
    {
        transform.position = transform.position + (Vector3.left * moveSpeed) * Time.deltaTime;

        if (transform.position.x < deadZone) Destroy(gameObject);
    }
}
