using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public Rigidbody Rigidbody;
    public Game Game;
    public SnakeTail _tail;
    public int pointsCount=1;
    public int pointsBest;
    public Cube currentCube;
    

    public void ReachFinish()
    {
        Rigidbody.velocity = Vector3.zero;
        // AudioPlayer.PlayFinish();
        Game.OnPlayerReachedFinish();
    }
    public void EatCoin()
    {
        _tail.AddSphere();
        Count();
    }
    public void Count()
    {
        pointsCount++;
        if (pointsCount >= pointsBest) pointsBest = pointsCount;
        Debug.Log("Count: " + pointsCount);
        Debug.Log("Best: " + pointsBest);
        Debug.Log("LegthTail"+ _tail.tailsSpheres.Count);
    }
    public void MeetBlock()
    {
        
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

    void Update()
    {
    }
}
