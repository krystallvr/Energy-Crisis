using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChangeSizeBtn : MonoBehaviour
{
    public Sprite image1;
    public Sprite image2;

    private bool moveButton = true;
    public float seconds = 10;

    //public float minScale = 1.0f;
    //public float maxScale = 1.5f;
    public float ScaleIncrement = 0.125f;
    private Vector3 currentScale;

    Vector3 v1 = new Vector3(150, 0, 0);
    Vector3 v2 = new Vector3(-150, 0, 0);


    Image button;

    void Start()
    {
        button = GetComponent<Image>();
        currentScale = transform.localScale;
    }

    void Update()
    {
        
    }

    public void ButtonLarger()
    {
        button.transform.position += v1;

        // moveButton = true;
        button.sprite = image2;

        /* if (moveButton == true)
         {
             transform.Translate(Vector2.right * speed * Time.deltaTime);
         }
 */
        /*if (transform.position.x >= 4.0f)
        {
            moveButton = false;
        }*/
    }

    public void ButtonSmaller()
    {
        button.transform.position += v2;

        //moveButton = true;
        button.sprite = image1;

        /*if (moveButton == true)
        {
            transform.Translate(-Vector2.right * speed * Time.deltaTime);
        }
*/
        /*if (transform.position.x <= 0.0f)
        {
            moveButton = false;
        }*/
    }

    public void PlayBtnBig()
    {
        AdjustScale(ScaleIncrement);
        button.sprite = image2;
    }

    public void PlayBtnSmall()
    {
        AdjustScale(-ScaleIncrement);
        button.sprite = image1;
    }

    private void AdjustScale(float scaleIncrement)
    {
        var scaleAdjust = currentScale.x + scaleIncrement;

       // if (scaleAdjust <= minScale || scaleAdjust >= maxScale)
         //   return;

        currentScale.x = scaleAdjust;
        currentScale.y = scaleAdjust;

        transform.localScale = currentScale;
    }


    public void OnClick()
    {
        ButtonSmaller();
    }
}
