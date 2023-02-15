using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Control : MonoBehaviour
{
    public Player player;
    public float Sensitivity;
    public float Speed;
    public SnakeTail _tail;

    private Vector3 _previousMousePosition;

    void Update()
    {
        player.Rigidbody.velocity = new Vector3(0, 0, Speed);
        if (Input.GetMouseButton(0))
        {
            Vector3 delta = Input.mousePosition - _previousMousePosition;
            player.Rigidbody.velocity= new Vector3 (delta.x *Sensitivity,0, Speed);
            
        }
        if (Input.GetMouseButton(2)) { _tail.AddSphere(); }

        _previousMousePosition = Input.mousePosition;
    }
}
