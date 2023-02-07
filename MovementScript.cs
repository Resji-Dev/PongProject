using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementScript : MonoBehaviour
{
    [SerializeField]private float force;
    [SerializeField]private Rigidbody2D rb;
    [SerializeField]private bool isPlayerLeft;
    public Vector2 start;
    private float input;
    // Start is called before the first frame update
    void Start()
    {
        start = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if (isPlayerLeft){
            input = Input.GetAxisRaw("Vertical");
        }
        else{
            input = Input.GetAxisRaw("Vertical2");
        }
        rb.velocity = new Vector2 (rb.velocity.x, input * force);
    }

    public void Reset(){
        rb.velocity = Vector2.zero;
        transform.position = start;
    }
}