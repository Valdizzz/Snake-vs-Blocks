using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : MonoBehaviour
{
    public int power;
    void Awake()
    {
        power = Random.Range(1, 2);

    }


    void Update()
    {

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.TryGetComponent(out Player Player))
        {
            Player.MeetBlock();


        }

    }
}
