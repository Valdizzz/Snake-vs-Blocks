using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Text_Cube : MonoBehaviour
{
    public Cube Cube;
    void Update()
    {
        GetComponent<TextMesh>().text = Cube.power.ToString();
        

    }
}
