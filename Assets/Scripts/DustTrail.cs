using UnityEngine;
using UnityEngine.SceneManagement;

public class DustTrail : MonoBehaviour
{
   [SerializeField] ParticleSystem particle;

   void OnCollisionEnter2D(Collision2D other)
   {
       if (other.gameObject.tag == "dust")
       {
           particle.Play();
       }
   }

   void OnCollisionExit2D(Collision2D other)
        {
            if (other.gameObject.tag == "dust")
            {

                particle.Stop();
            }
        }
}