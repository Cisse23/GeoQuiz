using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HoverImage : MonoBehaviour
{
    private FlagsGM gm;
    
    private SpriteRenderer rend;
    private Sprite original;
    public Sprite flag;
    private Color startColor;
    public Color hoverColor;
    public Color wrongColor;

    public bool isKnown;
    
    // Start is called before the first frame update
    void Start()
    {
        gm = FindObjectOfType<FlagsGM>();
        rend = GetComponent<SpriteRenderer>();
        //original = rend.GetComponent<Sprite>();
        original = rend.sprite;
        startColor = rend.color;
        isKnown = false;

        
    }


    public void OnMouseEnter()
    {
        if (!isKnown)
        {
            rend.color = hoverColor;
        } 
    }


    public void OnMouseExit()
    {
        if (!isKnown)
        {
            rend.color = startColor;
        }
        
    }


    public void OnMouseDown()
    {
        rend.sprite = flag;
        isKnown = true;
    }


}
