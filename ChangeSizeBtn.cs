using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChangeSizeBtn : MonoBehaviour
{
    public Sprite image1;
    public Sprite image2;

    private bool moveButton = true;
    private float speed = 2.0f;

    Image button;

    void Start()
    {
        button = GetComponent<Image>(); 
    }


    public void ButtonLarger()
    {
        moveButton = true;
        button.sprite = image2;

        if (moveButton == true)
        {
            transform.Translate(Vector2.right * speed * Time.deltaTime);
        }

        if (transform.position.x >= 1.6f)
        {
            moveButton = false;
        }
    }

    public void ButtonSmaller()
    {
        moveButton = true;
        button.sprite = image1;

        if (moveButton == true)
        {
            transform.Translate(-Vector2.right * speed * Time.deltaTime);
        }

        if (transform.position.x <= 0.0f) ;
        {
            moveButton = false;
        }
    }

    public void OnClick()
    {
        ButtonSmaller();
    }
}
