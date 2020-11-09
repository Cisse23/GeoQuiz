using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CountriesGM : MonoBehaviour
{
    public CountryData[] allCountries;

    public CountryData currentCountry;
    private List<string> foundCountries;
    private List<CountryData> remainingCountries;
    public int score;
    public Text scoreText;
    public Text findText;

    
    // Start is called before the first frame update
    void Start()
    {
        foreach (CountryData c in allCountries)
        {
            remainingCountries.Add(c);
        }

        Debug.Log(remainingCountries.Count);
        score = 0;
        UpdateScore();
        GetRandomCountry();
        UpdateFindText();
        
    }

    // Update is called once per frame
    void Update()
    {
        /*
        if (remainingCountries.Count == 0)
        {
            Debug.Log("YOU WIN!!");
        }
        */
        if (Input.GetAxis("Fire1")!=0)
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(ray, out RaycastHit hit))
            {
                string answer = hit.collider.gameObject.ToString();
            }
        }
    }

    /*
     * private void OnMouseDown()
    {
        string answer = name;

        if (answer == currentCountry.name)
        { 
            score ++;
            GetComponent<Renderer>().material.color = Color.green;
            UpdateScore();
        }
        GetRandomCountry();
    }
    */





    void UpdateScore()
    {
        scoreText.text = score.ToString();
    }

    public void UpdateFindText()
    {
        findText.text = currentCountry.ToString();
        //findText.text = GetRandomCountry();
    }

    public CountryData GetRandomCountry()
    {
        int randomIndex = Random.Range(0, remainingCountries.Count);
        currentCountry = remainingCountries[randomIndex];
        Debug.Log("New random country: " + currentCountry);
        //findText.text = currentCountry.ToString();
        UpdateFindText();
        return currentCountry;
        
    }

    public void CheckAnswer(CountryData currentCountry, string answer)
    {
        Debug.Log("Checking answer");
       
        if (currentCountry.name == answer)
        {
            score++;
            //GetComponent<Renderer>().material.color = Color.green;
            UpdateScore();
            // GetRandomCountry();
            foundCountries.Add(answer);
            remainingCountries.Remove(currentCountry);


        }

        else
        {
            score--;
            //GetComponent<Renderer>().material.color = Color.red;
            UpdateScore();
            GetRandomCountry();
            UpdateFindText();
        }

        
        

    }


    
}
