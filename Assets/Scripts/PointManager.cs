using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PointManager : MonoBehaviour
{
    private static PointManager _instance;

    public static PointManager instance
    {
        get
        {
            if (_instance == null)
            {
                _instance = GameObject.FindObjectOfType<PointManager>();
            }

            return _instance;
        }

    }
    private int score = 0;
    public int GetScore()
    {
        return score;
    }
    
    public void AddPoints(int _value)
    {
        score += _value;
    }

    public void RemovePoints(int _value)
    {
        score -= _value;
        if (score <= 0)
            score = 0;
    }
}
