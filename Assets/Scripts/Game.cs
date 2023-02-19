using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Game : MonoBehaviour
{
    public Control Control;
    public Player Player;
    public Canvas Winner;
    public Canvas GameWindow;
    public Canvas Lose;
    
    public enum State
    {
        Playing,
        Won,
        Loss
    }

    public State CurrentState { get; private set; }

    public void OnPlayerDied()
    {
        if (CurrentState != State.Playing) return;

        if (AmountOfLives != 0)
            {
                AmountOfLives--;
            Control.enabled = false;
            StartCoroutine(ExampleCoroutine2());
                return;
            }
        
        CurrentState = State.Loss;
        Control.enabled = false;
        Debug.Log("Game over!");
        PointsIndex = 0;
        StartCoroutine(ExampleCoroutine2());


    }
    public void ClearAllPlayerPrefs()
    {
        PlayerPrefs.DeleteAll();
    }

    public void OnPlayerReachedFinish()
    {
        if (CurrentState != State.Playing) return;

        CurrentState = State.Won;
        Control.enabled = false;
        LevelIndex++;
        BestScoreIndex = Player.pointsBest;
        PointsIndex = Player.pointsCount;
        Debug.Log("You won");
        
        StartCoroutine(ExampleCoroutine());

    }

    public int LevelIndex
    {
        get => PlayerPrefs.GetInt(LevelIdexKey, 0);
        private set
        {
            PlayerPrefs.SetInt(LevelIdexKey, value);
            PlayerPrefs.Save();
        }
    }
    public int AmountOfLives
    {
        get => PlayerPrefs.GetInt(AmountOfLivesKey, 2);
        private set
        {
            PlayerPrefs.SetInt(AmountOfLivesKey, value);
            PlayerPrefs.Save();
        }
    }

    public int BestScoreIndex
    {
        get => PlayerPrefs.GetInt(BestScoreIndexKey, 0);
        set
        {
            PlayerPrefs.SetInt(BestScoreIndexKey, value);
            PlayerPrefs.Save();
        }
    }
    public int PointsIndex
    {
        get => PlayerPrefs.GetInt(PointsIndexKey, 0);
        set
        {
            PlayerPrefs.SetInt(PointsIndexKey, value);
            PlayerPrefs.Save();
        }
    }

    private const string AmountOfLivesKey = "AmountOfLivesKey";

    public void BestScoreGet()
    {
        Player.pointsBest = BestScoreIndex;
    }

    public void ScorePointsGet()
    {
        Player.pointsCount = PointsIndex;
    }

    private const string PointsIndexKey = "PointsIndexKey";
    private const string BestScoreIndexKey = "BestSoreIndex";
    private const string LevelIdexKey = "LevelIndex";
    private void Awake()
    {
        if (PointsIndex > -1) PointsIndex--;
        GameWindow.enabled = true;
        Winner.enabled = false;
        Lose.enabled = false;
    }
    private void ReloadLevelWin()
    {

        Winner.enabled = true;
        GameWindow.enabled = false;
        Lose.enabled = false;

        // SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
    private void ReloadLevelLose()
    {

        Winner.enabled = false;
        GameWindow.enabled = false;
        Lose.enabled = true;

        // SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    IEnumerator ExampleCoroutine()
    {

        yield return new WaitForSeconds(1);
        ReloadLevelWin();
    }

    IEnumerator ExampleCoroutine2()
    {

        yield return new WaitForSeconds(1);
        ReloadLevelLose();
    }

}
