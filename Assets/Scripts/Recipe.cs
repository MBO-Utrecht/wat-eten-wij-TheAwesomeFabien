using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Recipe", menuName = "New Recipe", order = 0)]
public class Recipe : ScriptableObject
{
    public enum Kitchen
    {
        Italian,
        Eastern,
        Mexican,
        Dutch,
        JamieOliver,
        AllerHande,
        Easy
    }

    [SerializeField] private string name;
    [SerializeField] private Kitchen kitchen;
    [SerializeField] public string[] ingredients;
    [SerializeField] public int time;
}