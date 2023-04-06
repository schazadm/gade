using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject platformPrefab;
    public int platformCount = 300;

    // Start is called before the first frame update
    void Start()
    {
        Vector3 spawnPosition = new Vector3();
        int i = 0;
        do
        {
            spawnPosition.y += Random.Range(.5f, 2f);
            spawnPosition.x = Random.Range(-7f, 7f);
            Instantiate(platformPrefab, spawnPosition, Quaternion.identity);
            i += 3;
        } while (i < platformCount);
    }
}
