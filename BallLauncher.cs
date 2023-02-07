using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallLauncher : MonoBehaviour
{
    [SerializeField]Rigidbody2D rb;
    [SerializeField]float force;
    [SerializeField]bool test;
    public Vector2 start;
    
    // Start is called before the first frame update
    void Start()
    {
        start = transform.position;
         if(test){
            force = 40;
        }
        LaunchBall();
       
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void LaunchBall(){ 
       float x = Random.Range(0,2) == 0 ? 1 : -1;
       float y = Random.Range(0,2) == 0 ? 1 : -1;
       
       rb.velocity = new Vector2(x*force,y*force);
    }

    public void Reset(){
        rb.velocity = Vector2.zero;
        transform.position = start;
        LaunchBall();
    }

    public void Reset2(){
        rb.velocity = Vector2.zero;
        transform.position = start;
        rb.constraints = RigidbodyConstraints2D.FreezeAll;
    }
    
}
