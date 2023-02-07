using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    [Header("Moveables")]
    [SerializeField] GameObject Ball;
    [SerializeField] GameObject RightPlayer;
    [SerializeField] GameObject LeftPlayer;

    [Header("Goals")]
    [SerializeField] GameObject RightGoal;
    [SerializeField] GameObject LeftGoal;

    [Header("Score")]
    [SerializeField] GameObject RightScore;
    [SerializeField] GameObject LeftScore;
    [SerializeField] GameObject WinScreen;
    // Start is called before the first frame update

    private int ScoreLeft;
    private int ScoreRight;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void PlayerLeftScored(){
        ScoreLeft++;
        if (ScoreLeft < 7){
        LeftScore.GetComponent<TextMeshProUGUI>().text = ScoreLeft.ToString();
        Restart();
        }
        if(ScoreLeft == 7){
            WinScreen.GetComponent<TextMeshProUGUI>().text = ("Left Won!");
            ScoreRight = 0;
            ScoreLeft = 0;
            Continue();
        }
    }

    public void PlayerRightScored(){
        ScoreRight++;
        if (ScoreRight < 7){
        RightScore.GetComponent<TextMeshProUGUI>().text = ScoreRight.ToString();
        Restart();
        }
        if (ScoreRight == 7){
            WinScreen.GetComponent<TextMeshProUGUI>().text = "Right Won!";
            ScoreRight = 0;
            ScoreLeft = 0;
            Continue();
            
        }
    }

    private void Restart(){
        GameObject.Find("PlayerRight").GetComponent<MovementScript>().Reset();
        GameObject.Find("PlayerLeft").GetComponent<MovementScript>().Reset();
        GameObject.Find("Ball").GetComponent<BallLauncher>().Reset();
    }

    private void Continue(){
        RightPlayer.GetComponent<MovementScript>().enabled = false;
        LeftPlayer.GetComponent<MovementScript>().enabled = false;
        Ball.GetComponent<BallLauncher>().Reset2();

    }
}
