using UnityEngine;
using TMPro;

public class ScoreDisplay : MonoBehaviour
{
    public TextMeshProUGUI scoreText;

    void Start()
    {
        int finalScore = GameManager.Instance.GetScore();
        scoreText.text = "Score: " + finalScore.ToString();
    }
}
