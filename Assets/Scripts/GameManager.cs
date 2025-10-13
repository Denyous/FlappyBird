using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    private static int score = 0;

    public static void IncreaseScore()
    {
        score++;
        Debug.Log("Score Increased!!");
    }

    public static void GameOver()
    {
        Debug.Log("You Died");
    }

}
