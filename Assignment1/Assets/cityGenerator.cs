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
                Vector3 pos = new Vector3(w * buildingSpreader, 0, h * buildingSpreader);
                int n = Random.Range(0, buildings.Length);
                Instantiate(buildings[n], pos, Quaternion.identity);

            }
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}
