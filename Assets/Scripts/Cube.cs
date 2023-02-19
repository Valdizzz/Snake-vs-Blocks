using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : MonoBehaviour
{
    public int power;
    public Material _Cube;
    Renderer _Renderer;
    void Awake()
    {
        power = Random.Range(0, 7);
        _Renderer = GetComponent<Renderer>();

    }


    void Update()
    {
        _Renderer.material.SetFloat("_Power", power);
        //var thisCube = gameObject.GetComponent<Cube>();
        // GetComponent<Cube>().Update();
        //thisCube._Cube.SetFloat("_Power", power);
        // this._Cube.SetFloat("_Power", power);
        //_Cube.SetFloat("_Power", power);
        if (power <= 0) GameObject.Destroy(gameObject);

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
