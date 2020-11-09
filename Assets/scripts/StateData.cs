using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


[CreateAssetMenu(fileName = "New StateData", menuName = "State Data")]
public class StateData : ScriptableObject
{

    [SerializeField]
    public string stateName;

    [SerializeField]
    private Sprite sprite;

}
