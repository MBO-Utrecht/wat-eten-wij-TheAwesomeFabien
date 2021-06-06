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
        int randMonR = Random.Range(0, recipesMon.Length);
        string ingrMon = "";
        for (int i = 0; i < recipesMon[randMonR].ingredients.Length; i++)
        {
            ingrMon += " " + recipesMon[randMonR].ingredients[i] + ",";
        }
        ingrMon = ingrMon.Substring(0, ingrMon.Length - 1);
        PlayerPrefs.SetString("Maandag", "Maandag: " + recipesMon[randMonR].name + ". Ingredienten:" + ingrMon + ". Bereidingstijd: " + recipesMon[randMonR].time + " minuten.");
        
        int randTueR = Random.Range(0, recipesTue.Length);
        string ingrTue = "";
        for (int i = 0; i < recipesTue[randTueR].ingredients.Length; i++)
        {
            ingrTue += " " + recipesTue[randTueR].ingredients[i] + ",";
        }
        ingrTue = ingrTue.Substring(0, ingrTue.Length - 1);
        PlayerPrefs.SetString("Dinsdag", "Dinsdag: " + recipesTue[randTueR].name + ". Ingredienten:" + ingrTue + ". Bereidingstijd: " + recipesMon[randTueR].time + " minuten.");
        
        int randWedR = Random.Range(0, recipesWed.Length);
        string ingrWed = "";
        for (int i = 0; i < recipesWed[randWedR].ingredients.Length; i++)
        {
            ingrWed += " " + recipesWed[randWedR].ingredients[i] + ",";
        }
        ingrWed = ingrWed.Substring(0, ingrWed.Length - 1);
        PlayerPrefs.SetString("Woensdag", "Woensdag: " + recipesWed[randWedR].name + ". Ingredienten:" + ingrWed + ". Bereidingstijd: " + recipesMon[randWedR].time + " minuten.");
        
        int randThuR = Random.Range(0, recipesThu.Length);
        string ingrThu = "";
        for (int i = 0; i < recipesThu[randThuR].ingredients.Length; i++)
        {
            ingrThu += " " + recipesThu[randThuR].ingredients[i] + ",";
        }
        ingrThu = ingrThu.Substring(0, ingrThu.Length - 1);
        PlayerPrefs.SetString("Donderdag", "Donderdag: " + recipesThu[randThuR].name + ". Ingredienten:" + ingrThu + ". Bereidingstijd: " + recipesMon[randThuR].time + " minuten.");
        
        int randFriR = Random.Range(0, recipesFri.Length);
        string ingrFri = "";
        for (int i = 0; i < recipesFri[randFriR].ingredients.Length; i++)
        {
            ingrFri += " " + recipesFri[randFriR].ingredients[i] + ",";
        }
        ingrFri = ingrFri.Substring(0, ingrFri.Length - 1);
        PlayerPrefs.SetString("Vrijdag", "Vrijdag: " + recipesFri[randFriR].name + ". Ingredienten:" + ingrFri + ". Bereidingstijd: " + recipesMon[randFriR].time + " minuten.");
        
        int randSatR = Random.Range(0, recipesSat.Length);
        string ingrSat = "";
        for (int i = 0; i < recipesSat[randSatR].ingredients.Length; i++)
        {
            ingrSat += " " + recipesSat[randSatR].ingredients[i] + ",";
        }
        ingrSat = ingrSat.Substring(0, ingrSat.Length - 1);
        PlayerPrefs.SetString("Zaterdag", "Zaterdag: " + recipesSat[randSatR].name + ". Ingredienten:" + ingrSat + ". Bereidingstijd: " + recipesMon[randSatR].time + " minuten.");
        
        int randSunR = Random.Range(0, recipesSun.Length);
        string ingrSun = "";
        for (int i = 0; i < recipesSun[randSunR].ingredients.Length; i++)
        {
            ingrSun += " " + recipesSun[randSunR].ingredients[i] + ",";
        }
        ingrSun = ingrSun.Substring(0, ingrSun.Length - 1);
        PlayerPrefs.SetString("Zondag", "Zondag: " + recipesSun[randSunR].name + ". Ingredienten:" + ingrSun + ". Bereidingstijd: " + recipesMon[randSunR].time + " minuten.");
        
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
