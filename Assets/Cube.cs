using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : MonoBehaviour
{
    public int power;
    void Awake()
    {
        power = Random.Range(0, 2);

    }


    void Update()
    {
        if(power <= 0) GameObject.Destroy(gameObject);

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.TryGetComponent(out Player Player))
        {
            Player.currentCube = this;
            Player.MeetBlock();


        }

    }
}
