using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TextCount : MonoBehaviour
{
    public Player player;
    
    void Update()
    {
        GetComponent<TextMesh>().text = player.pointsCount.ToString();
        
    }
}
