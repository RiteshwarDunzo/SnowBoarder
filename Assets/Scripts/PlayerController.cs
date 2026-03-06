using UnityEngine;

public class PlayerController : MonoBehaviour
{
     Rigidbody2D rgbd2d;
     SurfaceEffector2D surfaceEffector2D;
      bool canMove = true;
    [SerializeField] private float torqueAmount = 1f;
    [SerializeField] private float baseSpeed = 1f;
    [SerializeField] private float boostSpeed = 1f;
    void Start()
    {
        rgbd2d = GetComponent<Rigidbody2D>();
        surfaceEffector2D = FindObjectOfType<SurfaceEffector2D>();
    }


    void Update()
    {
        if (canMove)
        {
            Rotateplayer();
            Speedplayer();
        }
    }

   public void DisableControls()
    {
        canMove=false;
    }
    void Rotateplayer()
    {
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            rgbd2d.AddTorque(torqueAmount);
        }
        else if (Input.GetKey(KeyCode.RightArrow)) 
        {
            rgbd2d.AddTorque(-torqueAmount);
        }
    }

    void Speedplayer()
    {
        if (Input.GetKey(KeyCode.UpArrow))
        {
            surfaceEffector2D.speed = boostSpeed;
        }
        else
        {
            surfaceEffector2D.speed = baseSpeed;
        }
    }
}
