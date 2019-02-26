using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChangeTextPos : MonoBehaviour
{
    public Text text;

    Vector3 v1 = new Vector3(150, 0, 0);
    Vector3 v2 = new Vector3(-150, 0, 0);
    public void MoveRight()
    {
        text.transform.position += v1;
    }

    public void MoveLeft()
    {
        text.transform.position += v2;
    }
}
