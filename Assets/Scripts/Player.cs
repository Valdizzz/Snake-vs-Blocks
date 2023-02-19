using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public Rigidbody Rigidbody;
    public Game Game;
    public SnakeTail _tail;
    public int pointsCount = 1;
    public int pointsBest;
    public Cube currentCube;
    [Min(0)]
    private AudioSource _audio;
    public AudioClip CoinCollect;
    public AudioClip BreakBlock;


    public void ReachFinish()
    {
        Rigidbody.velocity = Vector3.zero;
        Game.OnPlayerReachedFinish();
    }
    public void EatCoin()
    {
        _tail.AddSphere();
        Count();
    }
    public void Count()
    {
        _audio.PlayOneShot(CoinCollect);
        pointsCount++;
        if (pointsCount >= pointsBest) pointsBest = pointsCount;
        Debug.Log("Count: " + pointsCount);
        Debug.Log("Best: " + pointsBest);
        Debug.Log("LegthTail" + _tail.tailsSpheres.Count);
    }
    public void MeetBlock()
    {
       _audio.PlayOneShot(BreakBlock);
        if (currentCube.power >= pointsCount)
        {
            Die();
         }
        else
            while (currentCube.power > 0)
            {

                _tail.DeleteSphere();
                currentCube.power--;
                pointsCount--;
            }
    }

    public void Die()
    {
        Rigidbody.velocity = Vector3.zero;
        Game.OnPlayerDied();
        
    }
    private void Start()
    {
        _audio = GetComponent<AudioSource>();
        //Game.ScorePointsGet();
    }

    /* void Awake()
     {
         if (pointsCount != Game.PointsIndex)
         {
             if (Game.PointsIndex > pointsCount)
             for (int i = 1; i < Game.PointsIndex; i++)
             {
                 pointsCount++;
                 _tail.AddSphere();
             }
         }
     }*/
}
