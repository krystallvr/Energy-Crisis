using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnergyInfoDisplay : MonoBehaviour
{
    public Sprite coal, solar, water, nuclear;
    public Button coalBtn, solarBtn, waterBtn, nuclearBtn;
    public Image energyImage;
    public Text energyTxt;
    // Start is called before the first frame update
    void Start()
    {
        coalBtn.onClick.AddListener(CoalInfo);
        solarBtn.onClick.AddListener(SolarInfo);
        waterBtn.onClick.AddListener(WaterInfo);
        nuclearBtn.onClick.AddListener(NuclearInfo);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void CoalInfo()
    {
        energyImage.sprite = coal;
        energyTxt.text = "Coal Plants make up roughly 40% of all the energy produced on Earth, with 90 of all the coal mined in the US being consumed or energy usage. " +
            "For well over a century coal has been used as one of the most proficient source of energy for cities and towns. " +
            "The large amount of energy produced by these plants comes at a cost, as 30 percent of all the carbon monoxide produced in the US comes from the burning of coal in these large energy plants. " +
            "Along with the large amount of carbon emissions, particles from multiple heavy metals are strewn into the air supply. " +
            "These include metals such as mercury, lead, sulfur dioxide, and nitrogen oxides just to name a few. " +
            "You may also be surprised that while pollution from coal can be found in the air, it can also be found in the water as factories try to find places to dispose the incredibly large amounts of ash produced each day. ";
    }

    void SolarInfo()
    {
        energyImage.sprite = solar;
        energyTxt.text = "Solar uses the energy from the sun and converts it into power using a manufactured version of photosynthesis to produce energy. " +
            "This energy does not match the large levels produced by factories using fossil fuels and have a higher cost to create, but they have nowhere near the same environmental impact. " +
            "Solar farms require large amounts of water to cool down the panels since they absorb so much heat, thus it needs to be drawn from a close location. " +
            "No energy is without its environmental impacts though, as the installation of solar farms can cause land degradation as well as habitat loss.";


    }

    void WaterInfo()
    {
        energyImage.sprite = water;
        energyTxt.text = "";
    }

    void NuclearInfo()
    {
        energyImage.sprite = nuclear;
        energyTxt.text = "hee";
    }
}
