using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ProgressBarScript : MonoBehaviour
{
    public Player Player;
    public Transform Finish;
    public Slider Slider;

    private float _startZ;
    private float _minimumReachedZ;
    void Start()
    {
        _startZ = Player.transform.position.z; 
    }

  
    void Update()
    {
       
        float t = Mathf.InverseLerp(_startZ, Finish.transform.position.z, Player.transform.position.z);
        Slider.value = t;
    }
}
