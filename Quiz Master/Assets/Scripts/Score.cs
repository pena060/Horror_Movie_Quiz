using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Score : MonoBehaviour
{
    int currentScore = 0;
    int numOfQuestionsEncountered = 0;

   public int getCurrentScore(){
       return currentScore;
   }

    public void setCurrentScore(){
        currentScore++;
    }

    public int getNumOfQuestionsEncountered(){
        return numOfQuestionsEncountered;
    }

    public void setNumOfQuestionsEncountered(){
        numOfQuestionsEncountered++;
    }

    public int calculateTotalScore(){
            return Mathf.RoundToInt(currentScore / (float)numOfQuestionsEncountered * 100);
        
    }
    
}
