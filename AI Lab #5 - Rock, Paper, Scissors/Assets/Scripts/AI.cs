using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AI : MonoBehaviour
{

    public Sprite AIImage;
    public Sprite rock;
    public Sprite paper;
    public Sprite scissions;
    int aiChoice = 4;
    public void OnClick(int choice)
    {
        aiChoice = Random.Range(0, 3);

        if (aiChoice == 0)
        {
            AIImage = rock;
            if (choice == 0)
            {
                FindObjectOfType<AudioManager>().Play("Tie");
                Debug.Log("The opponent chose ROCK. You Tied!");
            }
            else if (choice == 1)
            {
                FindObjectOfType<AudioManager>().Play("Win");
                Debug.Log("The opponent chose ROCK. You Win!");
            }
            else
            {
                FindObjectOfType<AudioManager>().Play("Lose");
                Debug.Log("The opponent chose ROCK. You Lose!");
            }
        }
        else if (aiChoice == 1)
        {
            AIImage = paper;
            if (choice == 0)
            {
                FindObjectOfType<AudioManager>().Play("Lose");
                Debug.Log("The opponent chose PAPER. You Lose!");
            }
            else if (choice == 1)
            {
                FindObjectOfType<AudioManager>().Play("Tie");
                Debug.Log("The opponent chose PAPER. You Tied!");
            }
            else
            {
                FindObjectOfType<AudioManager>().Play("Win");
                Debug.Log("The opponent chose PAPER. You Win!");
            }
        }
        else
        {
            AIImage = scissions;
            if (choice == 0)
            {
                FindObjectOfType<AudioManager>().Play("Win");
                Debug.Log("The opponent chose SCISSOR. You Win!");
            }
            else if (choice == 1)
            {
                FindObjectOfType<AudioManager>().Play("Lose");
                Debug.Log("The opponent chose SCISSOR. You Lose!");
            }
            else
            {
                FindObjectOfType<AudioManager>().Play("Tie");
                Debug.Log("The opponent chose SCISSOR. You Tied!");
            }
        }
    }
    public int getAiChoice()
    {
        return aiChoice;
    }
}
