using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public Rigidbody Rigidbody;
    public Game Game;
    public SnakeTail _tail;

    public void ReachFinish()
    {
        Rigidbody.velocity = Vector3.zero;
        // AudioPlayer.PlayFinish();
        Game.OnPlayerReachedFinish();
    }
    public void EatCoin()
    {
        _tail.AddSphere();
    }

    void Update()
    {
    }
}
