using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FlagsGM : MonoBehaviour
{
    public CountryData[] allFlags;
    private List<CountryData> remainingFlags;
    public CountryData currentFlag;

    public int score;

    public Sprite currentFlagSprite;
    public Text scoreText;

    void Start()
    {
        foreach (CountryData f in allFlags)
        {
            remainingFlags.Add(f);
        }

        Debug.Log(remainingFlags.Count + " countries in Quiz");
        score = 0;
    }

    void Update()
    {

    }

    public CountryData GetRandomFlag()
    {
        int randomIndex = Random.Range(0, remainingFlags.Count);
        currentFlag = remainingFlags[randomIndex];
        Debug.Log("New random Flag: " + currentFlag.name);
        //findText.text = currentCountry.ToString();
        UpdateCurrentFlagSprite();
        return currentFlag;
    }

    void UpdateCurrentFlagSprite()
    {
        currentFlagSprite = currentFlag.flag;
    }

    void UpdateScore()
    {
        scoreText.text = score.ToString();
    }

}