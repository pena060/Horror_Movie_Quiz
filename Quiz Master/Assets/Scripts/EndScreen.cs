using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class EndScreen : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI finalScoreText;

    Score score;

    void Awake()
    {
        score = FindObjectOfType<Score>();
    }


    public void showScore(){
        finalScoreText.text = "Your Score: \n" + score.calculateTotalScore() + "%";
    }

}
