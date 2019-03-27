using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NuclearPlant : MonoBehaviour
{
    //private int nuclearType = 4; //Number to check against placement tiles 
    //public GameObject nucleatPlant;

    private float moneyTimer = 0.0f;
    private float powerTimer = 0.0f;
    private float pollutionTimer = 0.0f;
    //private float eventTimer = 0.0f; //timespan for check

    private bool isBuilt = true; //needs to start as false

    private float moneyMade = 0;
    private float powerOutput = 0;
    private float pollutionGrowth = 0;

    //Values of growth for Revenue, Power and Pollution Bar
    //private float moneyChange = 10.0f;
    private float powerChange = 15.0f;
    private float pollutionChange = 1.5f;

    //$10m Value to increase revenue over time
    private decimal revenueGrowth = 10000000m;
    public string revenueString = "10M";

    //Cost $300,000,000 to build
    public static decimal costToBuild = 300000000.00m;
    public string costString = "300M";

    //determines if player can build this plant
    public static bool canBuild = true;

    // Start is called before the first frame update
    void Start()
    {
        BuildingCost();
    }

    // Update is called once per frame
    void Update()
    {
        if (RevenueBar.startingAmount >= costToBuild)
        {
            canBuild = true;
        }

        GenerateRevenue();
        GeneratePower();
        GeneratePollution();
    }

    //accumulates money if factory is placed down.
    void GenerateRevenue()
    {
        if (isBuilt)
        {
            moneyTimer += Time.deltaTime;

            if (moneyTimer >= 7.5f)
            {
                //moneyMade += moneyChange;
                //RevenueBar.revenue = moneyMade; //grows revenue bar
                
                //Accrues revenue in the revenue bar
                FindObjectOfType<RevenueBar>().revenueText.text = "$" + (RevenueBar.startingAmount += revenueGrowth);

                FindObjectOfType<RevenueBar>().additionText.text = "+$" + revenueString;
                moneyTimer = 0;
                //Debug.Log(moneyMade);
            }
        }

    }

    void GeneratePower()
    {
        if (isBuilt)
        {
            powerTimer += Time.deltaTime;

            if (powerTimer >= 10.0f)
            {
                powerOutput += powerChange;
                PowerBar.power = powerOutput; //grows power bar
                powerTimer = 0;
                Debug.Log(powerOutput);
            }
        }
    }

    void GeneratePollution()
    {
        if (isBuilt)
        {
            pollutionTimer += Time.deltaTime;

            if (pollutionTimer >= 8.0f)
            {
                pollutionGrowth += pollutionChange;
                PollutionBar.pollution = pollutionGrowth; //grows pollution bar
                pollutionTimer = 0;
                Debug.Log("Nuclear generated " + pollutionGrowth + " amount of pollution!");
            }
        }
    }

    void BuildingCost()
    {
        if (isBuilt)
        {
            if (RevenueBar.startingAmount < costToBuild || RevenueBar.startingAmount <= 0)
            {
                canBuild = false;
            }
            else
            {
                canBuild = true;
                FindObjectOfType<RevenueBar>().revenueText.text = "$" + (RevenueBar.startingAmount -= costToBuild);

                FindObjectOfType<RevenueBar>().subtractionText.text = "-$" + costString;

                if (RevenueBar.startingAmount <= 0.0m)
                {
                    RevenueBar.startingAmount = 0.0m;
                    canBuild = false;
                }
            }
        }
    }
}
