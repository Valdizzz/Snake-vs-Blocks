using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LevelNumberText : MonoBehaviour
{
    public Text TextCurrent;
    public Text TextNext;
    public Text Lives;
    public Game Game;
    public Player Player;
    private string lives;
    char heart = '\u2665';
        //'\&#9829';

    private void Start()
    {
        TextCurrent.text = (Game.LevelIndex + 1).ToString();
        TextNext.text = (Game.LevelIndex + 2).ToString();

        LivesCount();

    }
    private void Update()
    {
        
       // BestScore.text = "? ? ? " + (Player.pointsBest).ToString();
      //  CurrentScore.text = (Player.pointsCount).ToString();
    }

    public void LivesCount() 
    {
        lives = "";
        if (Game.CurrentState != Game.State.Playing) return;
        for (int i = 0; i <= Game.AmountOfLives; i++)
        {
            lives += " "+heart+ " " ;
        }
        Lives.text = lives;
    }
}
