using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Random = UnityEngine.Random;

public class MakeList : MonoBehaviour
{
    [SerializeField] private Text[] daysUI;
    [SerializeField] private Recipe[] recipesMon;
    [SerializeField] private Recipe[] recipesTue;
    [SerializeField] private Recipe[] recipesWed;
    [SerializeField] private Recipe[] recipesThu;
    [SerializeField] private Recipe[] recipesFri;
    [SerializeField] private Recipe[] recipesSat;
    [SerializeField] private Recipe[] recipesSun;
    private void Start()
    {
        GetDaList();
    }

    public void MakeDaList()
    {
        PlayerPrefs.SetString("Maandag", "Maandag: " + recipesMon[Random.Range(0, recipesMon.Length)].name);
        PlayerPrefs.SetString("Dinsdag", "Dinsdag: " + recipesTue[Random.Range(0, recipesTue.Length)].name);
        PlayerPrefs.SetString("Woensdag", "Woensdag: " + recipesWed[Random.Range(0, recipesWed.Length)].name);
        PlayerPrefs.SetString("Donderdag", "Donderdag: " + recipesThu[Random.Range(0, recipesThu.Length)].name);
        PlayerPrefs.SetString("Vrijdag", "Vrijdag: " + recipesFri[Random.Range(0, recipesFri.Length)].name);
        PlayerPrefs.SetString("Zaterdag", "Zaterdag: " + recipesSat[Random.Range(0, recipesSat.Length)].name);
        PlayerPrefs.SetString("Zondag", "Zondag: " + recipesSun[Random.Range(0, recipesSun.Length)].name);
        
        GetDaList();
    }

    private void GetDaList()
    {
        if (PlayerPrefs.GetString("Maandag") != null)
        {
            daysUI[0].text = PlayerPrefs.GetString("Maandag");
            daysUI[1].text = PlayerPrefs.GetString("Dinsdag");
            daysUI[2].text = PlayerPrefs.GetString("Woensdag");
            daysUI[3].text = PlayerPrefs.GetString("Donderdag");
            daysUI[4].text = PlayerPrefs.GetString("Vrijdag");
            daysUI[5].text = PlayerPrefs.GetString("Zaterdag");
            daysUI[6].text = PlayerPrefs.GetString("Zondag");
        }
    }
}