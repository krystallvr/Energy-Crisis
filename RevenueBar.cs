using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RevenueBar : MonoBehaviour
{
    Image revenueBar;
    float maxRevenue = 100.0f;
    public static float revenue;
    //float timespan = 0.0f;

    public Text revenueText;
    public Text subtractionText;
    public Text additionText;

    //Player starts with $150m
    public static decimal startingAmount = 150000000.00m;
    //public static decimal startingAmount = 300000000.00m; ////test amount

    //Cost of overhead over time
    private decimal costAmount = 150000.00m;

    //Start is called before the first frame update
    void Start()
    {
        revenueText.text = "$"+startingAmount.ToString(); //Start player with 500k

        revenueBar = GetComponent<Image>();
        revenue = maxRevenue; //Start power at 100%
    }

    //Update is called once per frame
    void Update()
    {
        //Prevents player from having a $1b
        if (startingAmount >= 1000000000.00m)
        {
            startingAmount = 999999999.00m; 
        }

        //Should delay a change in subtraction text
        if (subtractionText.text != "")
        {
            System.Threading.Thread.Sleep(300);
            subtractionText.text = "";
        }

        //Should delay a change in addition text
        if (additionText.text != "")
        {
            System.Threading.Thread.Sleep(400);
            additionText.text = "";
        }

        //SubtractCost();
        //revenueBar.fillAmount = revenue / maxRevenue; //sets revenue bar to a percentage
    }

    //cost are subracted from revenue every 7.5 seconds
    //void SubtractCost()
    //{
    //    timespan += Time.deltaTime;

    //    if (timespan >= 5.0f) //lowered from 8f
    //    {
    //        //revenue -= 5.0f; //raised from 15f

    //        startingAmount -= costAmount;

    //        if (startingAmount <= 0)
    //        {
    //            startingAmount = 0.0f;
    //        }

    //        revenueText.text ="$"+ startingAmount.ToString(); //lower revenue bar amount
    //        timespan = 0.0f;
    //    }

    //}

    //void AddRevenue(float revAmount)
    //{
    //    revenue += revAmount;
    //}

}
