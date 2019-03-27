using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapZoom : MonoBehaviour
{
    public float minScale = 1.0f;
    public float maxScale = 2.0f;
    public float ScaleIncrement = 0.05f;

    private Vector3 currentScale;
    // Start is called before the first frame update
    void Start()
    {
        currentScale = transform.localScale;
    }

    // Update is called once per frame
    void Update()
    {
       
        if(Input.GetKey(KeyCode.UpArrow))
        {
            AdjustScale(ScaleIncrement);
        }

       
        if (Input.GetKey(KeyCode.DownArrow))
        {
            AdjustScale(-ScaleIncrement);
        }  
    }

    private void AdjustScale(float scaleIncrement)
    {
        var scaleAdjust = currentScale.x + scaleIncrement;

        if (scaleAdjust <= minScale || scaleAdjust >= maxScale)
            return;

        currentScale.x = scaleAdjust;
        currentScale.y = scaleAdjust;

        transform.localScale = currentScale;
    }
}
