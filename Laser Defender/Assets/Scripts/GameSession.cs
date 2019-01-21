using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameSession : MonoBehaviour {

    // Configuration Parameters
    [SerializeField] int totalScore = 0;

	void Awake ()
    {
        SetUpSingleton();
    }

    private void SetUpSingleton()
    {
        if (FindObjectsOfType(GetType()).Length > 1)
        {
            Destroy(gameObject);
        }
        else
        {
            DontDestroyOnLoad(gameObject);
        }
    }

    public int GetScore()
    {
        return totalScore;
    }

    public void AddToScore(int scoreValue)
    {
        totalScore += scoreValue;
    }

    public void ResetScore()
    {
        Destroy(gameObject);
    }
}
