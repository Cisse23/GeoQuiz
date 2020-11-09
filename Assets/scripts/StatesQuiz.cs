using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StatesQuiz : MonoBehaviour
{

    public StateData[] allStates;
    public List<string> knownStates;
    public InputField inputfield;

    public int score;
    public float timer;
    public bool timeIsrunning;
    public Text scoreText;
    public Text timerText;
    public Text knownStatesText;

    public GameObject startPanel;
    public GameObject gameOverPanel;
    public List<string> missingStates;
    public Text gameOverText;

    public GameObject spritesParent;

    private void Start()
    {
        startPanel.SetActive(true);
        gameOverPanel.SetActive(false);
        timer = 0;
        timeIsrunning = false;
    }
    void Update()
    {
        /*
        if (Input.GetKeyDown(KeyCode.Return))
        {
            CheckAnswer();
        }
        */

        if (timeIsrunning)
        {
            timer += Time.deltaTime;

            string minutes = Mathf.Floor(timer / 60).ToString("00");
            string seconds = (timer % 60).ToString("00");
            timerText.text = minutes + ":" + seconds;

            //print(string.Format("{0}:{1}", minutes, seconds));
        }



        string answer = inputfield.text;
        foreach (StateData sd in allStates)
        {
            if (answer == sd.stateName)
            {

                if (!knownStates.Contains(answer))
                {
                    inputfield.text = "";
                    score++;
                    UpdateScore();
                    knownStates.Add(answer);
                    knownStatesText.text = knownStatesText.text + answer + "\n";
                }

            }
        }
    }

    /*
     * void CheckAnswer()
    {
        string answer = inputfield.text;
        foreach (StateData sd in allStates)
        {
            if (answer == sd.stateName)
            {

                if (!knownStates.Contains(answer))
                {
                    inputfield.text = "";
                    score++;
                    UpdateScore();
                    knownStates.Add(answer);
                    knownStatesText.text = knownStatesText.text + answer + "\n";
                }

            }
        }
    }
    */

    void UpdateScore()
    {
        scoreText.text = score.ToString();
    }


    public void StartGame()
    {
        startPanel.SetActive(false);
        timeIsrunning = true;
    }
    public void GiveUp()
    {
        timeIsrunning = false;
        gameOverText.text = "You found all but " + (allStates.Length-knownStates.Count) + " states in " + timerText.text + ". You only missed: " + "\n";
        
        GetMissingStates();
        
        gameOverPanel.SetActive(true);
        
    }


    public void GetMissingStates()
    {
        foreach (StateData sd in allStates)
        {
            if (knownStates.Contains(sd.name))
            {
                continue;
            }
            else
            {
                gameOverText.text = gameOverText.text + sd.name + " ";
            }
        }

    }



}








