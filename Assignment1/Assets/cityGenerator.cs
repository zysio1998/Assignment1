using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cityGenerator : MonoBehaviour
{
    public GameObject[] buildings;
    public int mapWidth = 20;
    public int mapHeight = 20;
    int buildingSpreader = 3;

    // Start is called before the first frame update
    void Start()
    {
        for (int h = 0; h < mapHeight; h++)
        {
            for (int w = 0; w < mapWidth; w++)
            {
                //Perlion Noise return values 0 to 1 so we * 10 and cast as int for easy usage
                int result = (int)(Mathf.PerlinNoise(w/10.0f, h/10.0f) * 10);
                Vector3 pos = new Vector3(w * buildingSpreader, 0, h * buildingSpreader);
                if(result < 2)
                    Instantiate(buildings[0], pos, Quaternion.identity);
                else if(result < 4)
                    Instantiate(buildings[1], pos, Quaternion.identity);
                else if(result < 6)
                    Instantiate(buildings[2], pos, Quaternion.identity);
                else if(result < 8)
                    Instantiate(buildings[3], pos, Quaternion.identity);


            }
        }
    }
}
