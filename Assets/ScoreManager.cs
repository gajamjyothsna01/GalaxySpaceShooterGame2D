using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    int score = 0;

    public void ScoreUpdate(int scoreValue)
    {
        score = score + scoreValue;
        Debug.Log("Score: " + score);
    }
}
