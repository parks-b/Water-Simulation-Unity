using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

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
        if ((timer % 215) == 0){
            _fireparticleSystem.Stop(); 
            _smokeParticleSystem.Play();
            
            
        }
        if((timer % 650) == 0){
            timer = -15;
            _fireparticleSystem.Play();
             _smokeParticleSystem.Stop();
             _waterParticleSystem.Clear();
            timer = 0;
           // Debug.Log("poopyss");
            _waterParticleSystem.Play();
            
            //SceneManager.LoadScene("Menu");
            //this is blaines fautl hi

        }
        if((timer % 730) == 0)
        {
            SceneManager.LoadScene("Menu");
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
