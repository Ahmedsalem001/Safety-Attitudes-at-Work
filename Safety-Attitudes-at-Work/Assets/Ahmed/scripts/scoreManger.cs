using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class scoreManger : MonoBehaviour
{   
    public static scoreManger instance;
    public TextMeshProUGUI ScoreText;
    public score score;
    // int score = 0;

    private void Awake() {
        
            instance = this;
        
    }
    void Start()
    {
        ScoreText.text = score.scoreValue.ToString();
    }

    public void AddPoints() {
        score.scoreValue += 10;
        ScoreText.text = score.scoreValue.ToString();
    }
}
