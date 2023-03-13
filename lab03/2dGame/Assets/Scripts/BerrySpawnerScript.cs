using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BerrySpawnerScript : MonoBehaviour
{
    public GameObject berry;
    public float spawnRate = 2;
    public float heightOffset = 2;
    private float timer = 0;


    // Start is called before the first frame update
    void Start()
    {
        spawnBerry();
    }

    // Update is called once per frame
    void Update()
    {
        if (timer < spawnRate)
        {
            timer += Time.deltaTime;
        }
        else
        {
            spawnBerry();
            timer = 0;
        }
    }

    private void spawnBerry()
    {
        float lowestPoint = transform.position.y - heightOffset;
        float heighestPoint = transform.position.y + heightOffset;

        Instantiate(
            berry,
            new Vector3(transform.position.x, Random.Range(lowestPoint, heighestPoint), 0),
            transform.rotation
        );
    }
}
