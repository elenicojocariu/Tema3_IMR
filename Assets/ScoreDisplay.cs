using System.Diagnostics;
using UnityEngine;
using UnityEngine.UI;

public class ScoreDisplay : MonoBehaviour
{
    public static ScoreDisplay instance;
    public Text scoreText;
    public GenerateScor scor;
  /*  private void Awake()
    {
        instance = this;
    } */
    void Start()
    {
      
    }
    public void UpdateUI()
    {
        scoreText.text = "Scor: " + scor.score.ToString();
        UnityEngine.Debug.Log("yey" );
        UnityEngine.Debug.Log(scor.score.ToString());
    
    }
}
