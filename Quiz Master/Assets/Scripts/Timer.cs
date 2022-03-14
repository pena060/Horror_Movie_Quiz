using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Timer : MonoBehaviour
{
    [SerializeField] float timeToAnswerQuestion = 30f;
    [SerializeField] float timeToReviewAnswer = 10f;

    public float fillFraction;
    public bool LoadNextQuestion;
    float timerValue;

    public bool isWaitingForAnswer;
  
    void Update()
    {
        timerUpdate();
    }


    public void cancelTimer(){
        timerValue = 0;
    }

    void timerUpdate(){

        timerValue -= Time.deltaTime;

        if(isWaitingForAnswer){

            if(timerValue > 0){
                fillFraction = timerValue / timeToAnswerQuestion;

            }else{

                isWaitingForAnswer = false;
                timerValue = timeToReviewAnswer;
            }
        }else{

            if(timerValue > 0){
                fillFraction = timerValue / timeToReviewAnswer;

            }else{

                LoadNextQuestion = true;
                timerValue = timeToAnswerQuestion;
                isWaitingForAnswer = true;

            }

        }
    }
}
