using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadNewScene : MonoBehaviour
{
    public string newScene;

    void OnCollisionEnter2D(Collision2D collision)
    {
        SceneManager.LoadScene(newScene);
    }
}
