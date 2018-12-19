using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using System.Diagnostics;

public class time_and_high_score : MonoBehaviour {
    private float timeLeft = 200;
    public int playerScore = 0;
    public GameObject timeLeftUI;
    public GameObject playerScoreUI;

    void start()
    {
        DataManagement.datamanagenment.LoadData();
    }

    void Update ()
    {
        timeLeft -= Time.deltaTime;
        timeLeftUI.gameObject.GetComponent<Text>().text = ("TIME: " + (int) timeLeft);
        playerScoreUI.gameObject.GetComponent<Text>().text = ("ANDRÉ: " + playerScore);
        if (timeLeft < 0.1f)
        {
            SceneManager.LoadScene("A blast in the past"); 
        }
	}

    private void OnTriggerEnter2D(Collider2D trig)
    {
        if (trig.gameObject.name == "Finishline")
        {
            CountScore();
            DataManagement.datamanagenment.SaveData();
        }

        if (trig.gameObject.name == "Coin block")
        {
            playerScore += 10;
            Destroy(trig.gameObject);
        }

        if (trig.gameObject.name == "Question block")
        {
            playerScore += 10;
            Destroy(trig.gameObject);  
            
        }
    }

    void CountScore ()
    {
        playerScore = playerScore + (int)(timeLeft * 10);
        DataManagement.datamanagenment.highScore = playerScore + (int)(timeLeft * 10);
        DataManagement.datamanagenment.SaveData();
    }
}
