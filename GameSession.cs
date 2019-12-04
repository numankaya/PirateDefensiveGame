using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameSession : MonoBehaviour
{
    int score = 0;
    int cephane = 50;
    private void Awake()
    {
        SetUpSingleton();
    }

    private void SetUpSingleton()
    {
        int numberGameSessions = FindObjectsOfType<GameSession>().Length;
        if(numberGameSessions > 1)
        {
            Destroy(gameObject);
        }
        else
        {
            DontDestroyOnLoad(gameObject);
        }
    }

    public int GetCephane()
    {
        return cephane;
    }
    
    public void DecreaseCephane(int cephaneValue)
    {
        cephane -= cephaneValue;
        if (cephane <= 0)
        {
            StartCoroutine(WaitForCephane());
        }
    }

    IEnumerator WaitForCephane()
    {
        yield return new WaitForSeconds(10f);
        cephane = 50;
    }

    public int GetScore()
    {
        return score;
    }

    public void AddToScore(int scoreValue)
    {
        score += scoreValue;
    }

    public void ResetGame()
    {
        Destroy(gameObject);
    }
}
