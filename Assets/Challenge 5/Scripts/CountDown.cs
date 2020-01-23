using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Threading;

public class CountDown : MonoBehaviour
{
    public int timeLeft = 60;
    public Text countdown;
    private GameManagerX gameManagerX;

    void Start()
    {
     
    }
    public void StartTimer ()
    {
        gameManagerX = GameObject.Find("Game Manager").GetComponent<GameManagerX>();
        StartCoroutine("LoseTime");
        Time.timeScale = 1;
    }
    
    void Update () 
    {
        countdown.text = ("time: " + timeLeft);
        
        if (timeLeft <= 0)
        {
            gameManagerX.GameOver();
        }
    }
    
    //Simple Coroutine
    IEnumerator LoseTime()
    {
        while (true) {
            yield return new WaitForSeconds (1);
            timeLeft--; 
        }
    }
}