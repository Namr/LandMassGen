using UnityEngine;
using System.Collections;

public class Map : MonoBehaviour {
    //hex to be cloned
    public GameObject HexPrefab;

    //size of map in hex units
    int width = 20;
    int height = 20;
    //Base offsets NOTE: ORIGNAL VALUES FOR NO GRID SHAPE X:1.74 Z:1.5
    float xOffset = 1.762f;
    float zOffset = 1.53f;

    void Start () {
        //create a grid of hexes
        for (int x = 0; x < width; x++)
        {
            for (int y = 0; y < height; y++)
            {
                //offset the xPos
                float xPos = x * xOffset;

                // if we are on an odd row add extra XOffset to make everything fit nicely
                if (y % 2 == 1)
                {
                    xPos += xOffset/2f;
                }
                //add these gameObjects to the world with the calculated offset
                GameObject hex_go = (GameObject) Instantiate(HexPrefab, new Vector3(xPos,0,y * zOffset),Quaternion.identity);

                //change name and add hexes as children of map for better organization 
                hex_go.name = "Hex_" + x + "_" + y;
                hex_go.transform.SetParent(this.transform);
            }
        }
	}
	

	void Update () {
	
	}
}
