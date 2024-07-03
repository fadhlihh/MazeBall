using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    [SerializeField]
    private AudioSource _bounce;
    [SerializeField]
    private ParticleSystem _particle;
    private void OnCollisionEnter2D(Collision2D other)
    {
        // Memutar audio
        _bounce.Play();

        // Memunculkan Particle
        _particle.Play();
    }
}
