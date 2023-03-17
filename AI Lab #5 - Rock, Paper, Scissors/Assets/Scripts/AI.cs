using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AI : MonoBehaviour
{
    public void OnClick(int choice)
    {
        int aiChoice = Random.Range(0, 3);

        if (aiChoice == 0)
        {
            if (choice == 0)
            {
                Debug.Log("The opponent chose ROCK. You Tied!");
            }
            else if (choice == 1)
            {
                Debug.Log("The opponent chose ROCK. You Win!");
            }
            else
            {
                Debug.Log("The opponent chose ROCK. You Lose!");
            }
        }
        else if (aiChoice == 1)
        {
            if (choice == 0)
            {
                Debug.Log("The opponent chose PAPER. You Lose!");
            }
            else if (choice == 1)
            {
                Debug.Log("The opponent chose PAPER. You Tied!");
            }
            else
            {
                Debug.Log("The opponent chose PAPER. You Win!");
            }
        }
        else
        {
            if (choice == 0)
            {
                Debug.Log("The opponent chose SCISSOR. You Win!");
            }
            else if (choice == 1)
            {
                Debug.Log("The opponent chose SCISSOR. You Lose!");
            }
            else
            {
                Debug.Log("The opponent chose SCISSOR. You Tied!");
            }
        }
    }
}
