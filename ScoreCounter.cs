using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class ScoreCounter : MonoBehaviour
{
    [SerializeField]Rigidbody2D ball;
    
    
    
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D triggerInfo){
        if(triggerInfo.gameObject.name == "RightWall"){
            Debug.Log("Left Scored");
            GameObject.Find("GameManager").GetComponent<GameManager>().PlayerLeftScored();
        }
        if(triggerInfo.gameObject.name == "LeftWall"){
            Debug.Log("Right Scored");
            GameObject.Find("GameManager").GetComponent<GameManager>().PlayerRightScored();
        }
    }
}

