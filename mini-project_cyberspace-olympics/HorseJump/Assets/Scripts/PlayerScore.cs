using UnityEngine;

[CreateAssetMenu(menuName = "Player Score Value")]
public class PlayerScore : ScriptableObject
{
    public int score { get; set; }
    public int scoreToAdd;

    public void addScore()
    {
        score += scoreToAdd;
    }

    public void resetScore()
    {
        score = 0;
    }
}
