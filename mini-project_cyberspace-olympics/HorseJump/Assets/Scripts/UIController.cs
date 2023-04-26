using UnityEngine;
using TMPro;

public class UIController : MonoBehaviour
{
    public TextMeshProUGUI scoreText;
    public TextMeshProUGUI lvlText;
    public PlayerScore playerScore;

    private void Start()
    {
        playerScore.resetScore();
    }

    // Update is called once per frame
    void Update()
    {
        showScore();
    }

    public void showScore()
    {
        scoreText.text = playerScore.score.ToString();
    }
}
