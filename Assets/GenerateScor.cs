using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenerateScor : MonoBehaviour
{
    public int score = 0;

    void Start()
    {     
    }
    
    public  void IncreaseScore()
    {
        score += 1;
        ScoreDisplay.instance.UpdateUI();
    }
    public void DisplayScore()
    {
        Debug.Log("Scor: " + score);
    }
    // Update is called once per frame
    void Update()
    {
    }
}
