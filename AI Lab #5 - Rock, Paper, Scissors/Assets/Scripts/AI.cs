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
    public Text tex;
    int aiChoice = 4;
    public void OnClick(int choice)
    {
        aiChoice = Random.Range(0, 3);

        if (aiChoice == 0)
        {
            AIImage = rock;
            if (choice == 0)
            {
                tex.text = "The opponent chose ROCK. You Tied!";
                FindObjectOfType<AudioManager>().Play("Tie");
                Debug.Log("The opponent chose ROCK. You Tied!");
            }
            else if (choice == 1)
            {
                tex.text = "The opponent chose ROCK. You Win!";
                FindObjectOfType<AudioManager>().Play("Win");
                Debug.Log("The opponent chose ROCK. You Win!");
            }
            else
            {
                tex.text = "The opponent chose ROCK. You Lose!";
                FindObjectOfType<AudioManager>().Play("Lose");
                Debug.Log("The opponent chose ROCK. You Lose!");
            }
        }
        else if (aiChoice == 1)
        {
            AIImage = paper;
            if (choice == 0)
            {
                tex.text = "The opponent chose PAPER. You Lose!";
                FindObjectOfType<AudioManager>().Play("Lose");
                Debug.Log("The opponent chose PAPER. You Lose!");
            }
            else if (choice == 1)
            {
                tex.text = "The opponent chose PAPER. You Tied!";
                FindObjectOfType<AudioManager>().Play("Tie");
                Debug.Log("The opponent chose PAPER. You Tied!");
            }
            else
            {
                tex.text = "The opponent chose PAPER. You Win!";
                FindObjectOfType<AudioManager>().Play("Win");
                Debug.Log("The opponent chose PAPER. You Win!");
            }
        }
        else
        {
            AIImage = scissions;
            if (choice == 0)
            {
                tex.text = "The opponent chose SCISSOR. You Win!";
                FindObjectOfType<AudioManager>().Play("Win");
                Debug.Log("The opponent chose SCISSOR. You Win!");
            }
            else if (choice == 1)
            {
                tex.text = "The opponent chose SCISSOR. You Lose!";
                FindObjectOfType<AudioManager>().Play("Lose");
                Debug.Log("The opponent chose SCISSOR. You Lose!");
            }
            else
            {
                tex.text = "The opponent chose SCISSOR. You Tied!";
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
