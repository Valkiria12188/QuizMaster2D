using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreKeeper : MonoBehaviour
{
    int correctAnswers = 0;
    int questionSeen = 0;

    public int GetCorrectAnswers()
    {
        return correctAnswers;
    }

    public void incerementCorrectAnswers()
    {
        correctAnswers++;
    }

    public int GetQuestionSeen()
    {
        return questionSeen;
    }

    public void incerementQuestionSeen()
    {
        questionSeen++;
    }
    public int CalculateScore()
    {
        return Mathf.RoundToInt(correctAnswers / (float)questionSeen * 100);
    }




    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
