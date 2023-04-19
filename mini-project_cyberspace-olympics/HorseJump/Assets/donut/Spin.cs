using UnityEngine;

public class Spin : MonoBehaviour
{

    private void Start()
    {
    }

    void Update()
    {
        transform.Rotate(10f * Time.deltaTime, 30f * Time.deltaTime, 20f * Time.deltaTime, Space.Self);
    }
}
