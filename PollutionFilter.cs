using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PollutionFilter : MonoBehaviour
{
    float duration = 3;
    SpriteRenderer spriteRend;
    public Sprite pollSprite;
    float pollAmount;
    Color spriteColor;

    void Update()
    {
        spriteColor = spriteRend.GetComponent<SpriteRenderer>().color;
        spriteColor.a = Mathf.Lerp(0, 1, pollAmount);

        if (spriteColor.a > 1)
        {
            spriteColor.a = 1;
        }

        spriteRend.GetComponent<SpriteRenderer>().color = spriteColor;
    }
}
