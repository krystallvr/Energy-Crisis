using UnityEngine;
using UnityEngine.UI;

public class PollutionBar : MonoBehaviour
{
    Image pollutionBar;
    float maxPollution = 100.0f;
    public static float pollution;
    float timespan = 0.0f;

    // Start is called before the first frame update
    void Start()
    {
        pollutionBar = GetComponent<Image>();
        pollution = 0.0f; //Start pollution at 0%
    }

    // Update is called once per frame
    void Update()
    {
        //DispersePollution();
        pollutionBar.fillAmount = pollution / maxPollution; //sets pollution bar to a percentage

        //Debug.Log(pollutionBar.fillAmount);
        //Condition to determine game over
        if (pollutionBar.fillAmount.Equals(1))
        {
            FindObjectOfType<GameManager>().GameOver();
        }
    }

    //Pollution disperses every 10 seconds
    void DispersePollution()
    {
        timespan += Time.deltaTime;

        if (timespan >= 8.5f)
        {
            pollution -= 0.5f;
            timespan = 0;
        }
    }

    void AddPollution(float pollAmount)
    {
        pollution += pollAmount;
    }
}
