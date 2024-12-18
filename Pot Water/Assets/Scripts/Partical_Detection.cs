using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Partical_Detection : MonoBehaviour
{
    [SerializeField] ParticleSystem _fireparticleSystem;
    [SerializeField] ParticleSystem _smokeParticleSystem;
    [SerializeField] ParticleSystem _waterParticleSystem;
    float timer = 0;
    // Start is called before the first frame update
    
    void Start(){
        _smokeParticleSystem.Stop();
    }
    void Update()
    {
        timer++;
        if ((timer % 200) == 0){
            _fireparticleSystem.Stop(); 
            _smokeParticleSystem.Play();
            
            
        }
        if((timer % 600) == 0){
            _fireparticleSystem.Play();
             _smokeParticleSystem.Stop();
             _waterParticleSystem.Clear();
             _waterParticleSystem.Play();

        }
    }

    public void OnParticleCollision(GameObject other)
    {
        print("hit");
        if (other.gameObject.tag == "Water")
        {
            print("hit");
            _fireparticleSystem.Stop();
        }
    }
   
}
