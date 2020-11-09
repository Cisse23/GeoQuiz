using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName ="New CountryData", menuName ="Country Data")]
public class CountryData : ScriptableObject
{
    //[SerializeField]
    //public string countryName;

    [SerializeField]
    public Sprite sprite;

    [SerializeField]
    public Sprite flag;

    [SerializeField]
    public string capital;

    [SerializeField]
    public string continent;
}
