using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PowerBar : MonoBehaviour
{
    Image powerBar;
    float maxPower = 100.0f;
    public static float power;
    float timespan = 0.0f;

    // Start is called before the first frame update
    void Start()
    {
        powerBar = GetComponent<Image>();
        power = 35.0f; //Start power at 35%
    }

    // Update is called once per frame
    void Update()
    {
        //DepletePower();
        powerBar.fillAmount = power / maxPower; //sets power bar to a percentage
    }

    //Depletes power every 10 seconds
    void DepletePower()
    {
        timespan += Time.deltaTime;

        if (timespan >= 10.0f)
        {
            power -= 3.0f; //raise it up from 10f
            timespan = 0;
        }
    }

    void AddPower(float powerAmount)
    {
        power += powerAmount;
    }

}
