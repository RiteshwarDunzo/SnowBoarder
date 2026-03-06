using System;
using UnityEngine.SceneManagement;
using UnityEngine;

public class FinishLine : MonoBehaviour
{
  [SerializeField] float delay = 2f;
  [SerializeField] ParticleSystem particle;
  public AudioSource audio;
  
   void OnTriggerEnter2D(Collider2D other)
  {
    if (other.gameObject.tag == "Player")
    {
     
      particle.Play();
      GetComponent<AudioSource>().PlayOneShot(audio.clip);
      Invoke("Reloadscene", delay);
    }
  }
  void Reloadscene()
  {
    SceneManager.LoadScene(0);
  }
}

