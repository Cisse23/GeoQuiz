using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HoverColor : MonoBehaviour
{
    private Color startcolor;
    private Renderer rend;
    public Color correct;
    public Color wrong;
    public CountriesGM gameManager;



    void Start()
    {
        rend = GetComponent<Renderer>();
        //renderer.material.color = Color.blue;


    }

    void OnMouseEnter()
    {
        startcolor = rend.material.color;
        rend.material.color = Color.yellow;
    }
    void OnMouseExit()
    {
        if (rend.material.color == Color.yellow)
        {
            rend.material.color = startcolor;
        }

    }

    void OnMouseDown()
    {
        Debug.Log(name);
        gameManager.CheckAnswer(gameManager.currentCountry, name);
        //rend.material.color = wrong;
    }
}