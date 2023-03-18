using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class DispayResult : MonoBehaviour
{
    public GameObject AI;
    public Image ima;
    public int result;
    public Sprite rock;
    public Sprite paper;
    public Sprite scissions;
    // Update is called once per frame
    void Update()
    {
        result = AI.GetComponent<AI>().getAiChoice();
        if (result != 4)
        {
            result = AI.GetComponent<AI>().getAiChoice();
            if (result == 0)
            {
                ima.sprite = rock;

            }
            else if (result == 1)
            {
                ima.sprite = paper;
            }
            else if (result == 2)
            {
                ima.sprite = scissions;
            }
        }
    }
}
