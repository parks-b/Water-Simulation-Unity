using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Partical_Detection : MonoBehaviour
{
    [SerializeField] ParticleSystem _particleSystem;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void OnParticleCollision(GameObject other)
    {
        if (other.gameObject == _particleSystem)
        {
            print("hit itself");
        }
    }
}
