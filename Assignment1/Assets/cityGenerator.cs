using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cityGenerator : MonoBehaviour
{
    public GameObject[] buildings;
    public GameObject xStreet;
    public GameObject zStreet;
    public GameObject Crossroad;
    public int mapWidth = 100;
    public int mapHeight = 100;
    int[,] mapgrid; //2D array
    int buildingSpreader = 11;

    // Start is called before the first frame update
    void Start()
    {
        float diffLocation = Random.Range(0, 100); //or hardcode a number
        mapgrid = new int[mapWidth, mapHeight];

        //gather map data
        for (int h = 0; h < mapHeight; h++)
        {
            for (int w = 0; w < mapWidth; w++)
            {
                //Perlin Noise return values 0 to 1 so we * 10 and cast as int for easy usage
                mapgrid[w,h] = (int)(Mathf.PerlinNoise(w / 10.0f + diffLocation, h / 10.0f + diffLocation) * 10);
            }
        }

        //build x streets
        int x = 0;
        for(int n=0; n < 50; n++)
        {
            //loop throught the entire height of the map
            for(int h = 0; h <mapHeight; h++)
            {
                mapgrid[x, h] = -1;
            }
            x += Random.Range(2, 6);
            if (x >= mapWidth) break;
        }

        //build z streets
        int z = 0;
        for (int n = 0; n < 10; n++)
        {
            //loop throught the entire height of the map
            for (int w = 0; w < mapWidth; w++)
            {
                //add crossroads
                if (mapgrid[w, z] == -1)
                    mapgrid[w, z] = -3;
                else
                    mapgrid[w, z] = -2;
            }
            z += Random.Range(2, 20);
            if (z >= mapHeight) break;
        }


        //generate city               
        for (int h = 0; h < mapHeight; h++)
        {
            for (int w = 0; w < mapWidth; w++)
            {
                int result = mapgrid[w, h];
                Vector3 pos = new Vector3(w * buildingSpreader, 0, h * buildingSpreader);
                if(result == -3)
                    Instantiate(Crossroad, pos, Crossroad.transform.rotation);
                else if (result == -2)
                    Instantiate(xStreet, pos, xStreet.transform.rotation);
                else if (result == -1)
                    Instantiate(zStreet, pos, zStreet.transform.rotation);
                else if (result < 2)
                    Instantiate(buildings[0], pos, Quaternion.identity);
                else if(result < 4)
                    Instantiate(buildings[1], pos, Quaternion.identity);
                else if(result < 6)
                    Instantiate(buildings[2], pos, Quaternion.identity);
                else if(result < 7)
                    Instantiate(buildings[3], pos, Quaternion.identity);
                else if (result < 10)
                    Instantiate(buildings[4], pos, Quaternion.identity);


            }
        }
    }
}
