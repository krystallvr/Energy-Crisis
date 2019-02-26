using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoalPlant : MonoBehaviour
{
    private int coalType = 1; //Number to check against placement tiles 
    private decimal moneyMade = 0;
    private float moneyTimespan = 0.0f;
    private float powerTimespan = 0.0f;
    //private float eventTimespan = 0.0f; //timespan for check
    private bool isBuilt = false;
    private float powerOutput = 0;
    //public GameObject coalPlant;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        GenerateRevenue();
        GeneratePower();
    }

    //accumulates money if factory is placed down.
    void GenerateRevenue()
    {
        if (isBuilt)
        {
            moneyTimespan += Time.deltaTime;

            if (moneyTimespan >= 10.0f)
            {
                moneyMade += 250000.00m;
                moneyTimespan = 0;
            }
        }

    }

    void GeneratePower()
    {
        if (isBuilt)
        {
            powerTimespan += Time.deltaTime;

            if (powerTimespan >= 10.0f)
            {
                powerOutput += 5.0f;
                PowerBar.power = powerOutput;
                powerTimespan = 0;
            }
        }
    }

    private void DestroyPlant()
    {
        Destroy(this.gameObject, 1);
    }

    
    /*//method to break/pause the plant output of money and power untill there is a repair
    void MalfunctionEvent()
    {
        if (isBuilt)
        {
            
        }
    }*/
}
