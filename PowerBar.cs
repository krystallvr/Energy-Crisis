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
        power = maxPower;
    }

    // Update is called once per frame
    void Update()
    {
        DepletePower();
        powerBar.fillAmount = power / maxPower;
    }

    void DepletePower()
    {
        timespan += Time.deltaTime;

        if (timespan >= 10.0f)
        {
            power -= 10.0f;
            timespan = 0;
        }

    }


}
