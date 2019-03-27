using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class ClickBuilder : MonoBehaviour
{
    public int Current_building = 0;
    public GameObject CoalFactory;
    public GameObject SolarFactory;
    public GameObject NuclearFactory;
    public GameObject WaterFactory;

    //Should prevent building of factories if there isn't enough starting revenue
    private void Awake()
    {
        //Check Coal
        if (RevenueBar.startingAmount >= CoalPlant.costToBuild)
        {
            CoalPlant.canBuild = true;
        } else
            CoalPlant.canBuild = false;

        //Check Nuclear
        if (RevenueBar.startingAmount >= NuclearPlant.costToBuild)
        {
            NuclearPlant.canBuild = true;
        }
        else
            NuclearPlant.canBuild = false;

        //Check Water
        if (RevenueBar.startingAmount >= WaterPlant.costToBuild)
        {
            WaterPlant.canBuild = true;
        }
        else
            WaterPlant.canBuild = false;

        //Check Solar
        if (RevenueBar.startingAmount >= SolarPlant.costToBuild)
        {
            SolarPlant.canBuild = true;
        }
        else
            SolarPlant.canBuild = false;
    }


    public void SetBuilding(int n)
    {
        switch (n)
        {
            case 0:
                Debug.Log("invalid building type");
                Current_building = 0;
                break;
            case 1:
                Current_building = n;
                Debug.Log("Current Building Set to Coal");
                break;
            case 2:
                Current_building = n;
                Debug.Log("Current Building Set to Solar");
                //Debug.Log("Current Building Unavailable");
                break;
            case 3:
                Current_building = n;
                Debug.Log("Current Building Set to Nuclear");
                //Debug.Log("Current Building Set to Unknown");
                break;
            case 4:
                Current_building = n;
                Debug.Log("Current Building Set to Water");
                break;
        }
    }
    public void Build(int n, GameObject i)
    {
        if(Current_building == 0 || n == 0)
        {
            Debug.Log("No Building Selected!");
        }

        if (Current_building == 1 && n == 1)
        {
            if (CoalPlant.canBuild)
            {
                //Debug.Log("Coal Built!");
                GameObject newCoal = Instantiate(CoalFactory, i.transform.position, transform.rotation);
                newCoal.transform.SetParent(i.transform);
            }

        }

        if(Current_building == 2 && n == 2)
        {
            if (SolarPlant.canBuild)
            {
                Debug.Log("Solar Built!");
                GameObject newSolar = Instantiate(SolarFactory, i.transform.position, transform.rotation);
                newSolar.transform.SetParent(i.transform);
            }
        }

        if(Current_building == 3)
        {
            if(n == 2)
            {
                if (NuclearPlant.canBuild)
                {
                    Debug.Log("Nuclear Built!");
                    GameObject newNuclear = Instantiate(NuclearFactory, i.transform.position, transform.rotation);
                    newNuclear.transform.SetParent(i.transform);
                }
            }
            if(n == 1)
            {
                if (NuclearPlant.canBuild)
                {
                    Debug.Log("Nuclear Built!");
                    GameObject newNuclear = Instantiate(NuclearFactory, i.transform.position, transform.rotation);
                    newNuclear.transform.SetParent(i.transform);
                }
            }
        }

        if(Current_building == 4 && n == 4)
        {
            if (WaterPlant.canBuild)
            {
                Debug.Log("Water Built!");
                GameObject newWater = Instantiate(WaterFactory, i.transform.position, transform.rotation);
                newWater.transform.SetParent(i.transform);
            }
        }
    }
}
