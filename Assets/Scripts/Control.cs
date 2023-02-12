using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Control : MonoBehaviour
{
    public Player player;
    public float Sensitivity;

    private Vector3 _previousMousePosition;

    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            Vector3 delta = Input.mousePosition - _previousMousePosition;
            player.Rigidbody.velocity= new Vector3 (delta.x *Sensitivity,0,delta.y*Sensitivity);
        }

        _previousMousePosition = Input.mousePosition;
    }
}
