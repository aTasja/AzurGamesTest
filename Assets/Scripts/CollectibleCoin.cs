using System;
using System.Collections;
using System.Collections.Generic;
using Player;
using UnityEngine;

public class CollectibleCoin : MonoBehaviour
{
    private ParticleSystem _particleSystem;
    
    private void Start()
    {
        _particleSystem = GetComponent<ParticleSystem>();
        iTween.RotateBy(gameObject, iTween.Hash("y", 1f, "looptype", iTween.LoopType.loop, "easetype", iTween.EaseType.linear));
    }
    
    private void OnTriggerEnter(Collider other)
    {
        if(other.GetComponent<PlayerPurse>())
            PlayParticleEffect();
    }

    private void PlayParticleEffect()
    {
        _particleSystem.Play();
        Destroy(gameObject, _particleSystem.main.duration);
    }
}
