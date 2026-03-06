using System;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CrashDetector : MonoBehaviour
{   
    [SerializeField] float delay = 2f;
    public float delay2 = 2f;
    [SerializeField] ParticleSystem particle;
    public AudioSource audio;
    public AudioSource audio2;
    bool particleplayed = true;
     void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "dust")
        {
            if (particleplayed)
            {
                FindObjectOfType<PlayerController>().DisableControls();
                particle.Play();
                GetComponent<AudioSource>().PlayOneShot(audio.clip);
                Invoke("Reloadscene", delay);
                particleplayed = false;
            }
        }
    }
    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag == "rock")
        { if(particleplayed)
            FindObjectOfType<PlayerController>().DisableControls();
            GetComponent<AudioSource>().PlayOneShot(audio2.clip);
            Invoke("Reloadscene", delay2);
            particleplayed = false;
        }
    }
    void Reloadscene()
    {
        SceneManager.LoadScene(0);
    }
}