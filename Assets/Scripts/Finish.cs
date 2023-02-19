using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Finish : MonoBehaviour
{
    public ParticleSystem _particleSystem;
    public AudioSource _reachedFinish;
    private void OnCollisionEnter(Collision collision)
    {
        //_particleSystem = GetComponent<ParticleSystem>();
        if (collision.collider.TryGetComponent(out Player player))
        {
            player.ReachFinish();
            _particleSystem.Play();
            _reachedFinish.Play();
        }
    }
    private void Awake()
    {
        _reachedFinish = GetComponent<AudioSource>();
    }

}
