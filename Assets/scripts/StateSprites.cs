using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StateSprites : MonoBehaviour
{
    private Color startcolor;
    private Renderer rend;
    public Color correct;
    public StatesQuiz gameManager;


    void Start()
    {
        rend = GetComponent<Renderer>();

    }

    void Update()
    {
        if (gameManager.knownStates.Contains(name))
        {
            rend.material.color = Color.green;
        }
    }

}
