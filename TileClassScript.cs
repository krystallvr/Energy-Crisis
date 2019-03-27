using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TileClassScript : MonoBehaviour
{
    //tile tipe reference
    // 1 == dirt
    // 2 == grass
    // 3 == Mountain
    // 4 == Water
    // This number is edited per tile in order to make sure each tile is correctly labled atm.
    // However at somepoint such as when we begin level 2 this will be put onto a tile and the tile will be made into a prefab
    // in order to make editing and creating future levels much faster in terms of getting it up and running.
    public int tiletipe = 0;
    public GameObject other;
    public GameObject Me;

    private void Start()
    {
        if(other == null)
        {
            other = GameObject.FindWithTag("Canvas");
        }
    }

    //handles interaction per tile.
    public void ButtonPress()
    {
        Debug.Log("tile Pressed!");
        Debug.Log(tiletipe);
        other.GetComponent<ClickBuilder>().Build(tiletipe, Me);
    }
   

}
