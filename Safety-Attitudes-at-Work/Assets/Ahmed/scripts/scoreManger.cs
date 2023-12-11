using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class scoreManger : MonoBehaviour
{   
    public static scoreManger instance;
    public TextMeshProUGUI ScoreText;
    int score = 0;

    private void Awake() {
        
            instance = this;
        
    }
    void Start()
    {
        ScoreText.text = score.ToString();
    }

    public void AddPoints() {
        score += 5;
        ScoreText.text = score.ToString();
    }
}
