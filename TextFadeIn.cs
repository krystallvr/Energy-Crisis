using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextFadeIn : MonoBehaviour
{
    float duration = 3;
    Color textColor;
    float ratio;

    public Text gameOverText;

    void Update()
    {
        textColor = gameOverText.color;
        ratio = Time.time / duration;
        textColor.a = Mathf.Lerp(0,1, ratio);
        gameOverText.color = textColor;
    }
}
