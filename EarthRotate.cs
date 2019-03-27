using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EarthRotate : MonoBehaviour
{
    public Image world;

    public Vector3 v1 = new Vector3(1, 0, 0);
    public Vector3 v2 = new Vector3(178, 0, 0);
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        while (world.transform.position != v2)
        {
            world.transform.position += v1;
        }
    }
}
