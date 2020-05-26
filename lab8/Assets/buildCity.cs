using UnityEngine;
using System.Collections;

public class buildCity : MonoBehaviour
{
    public GameObject[] buildings;
    public GameObject xstreets;
    public GameObject zstreets;
    public GameObject crossroad;
    public int mapWidth = 20;
    public int mapHeight = 20;
    int[,] mapgrid;
    int buildingFootprint = 3;

    void Start()
    {
        mapgrid = new int[mapWidth, mapHeight];
        //generate map data
        for(int h = 0; h < mapHeight; h++)
        {
            for(int w = 0; w <mapWidth; w++)
            {
                mapgrid[w,h] = (int) (Mathf.PerlinNoise(w/10.0f, h/10.0f) * 10);
            }
        }

        //build streets
        int x = 0;
        for(int n = 0; n < 50; n++)
        {
            for(int h = 0; h < mapHeight; h++) // cycle through the height on the map
            {
                mapgrid[x, h] = -1;
            }
            x += Random.Range(4, 7);
            if (x >= mapWidth) break;
        }

        int z = 0;
        for(int n = 0; n < 10; n++)
        {
            for(int w = 0; w < mapWidth; w++)
            {
                Debug.Log(z);
                if (mapgrid[w, z] == -1) // put in a crossroad
                    mapgrid[w, z] = -3;
                else
                    mapgrid[w, z] = -2;
            }
            z += Random.Range(5, 20);
            if (z >= mapHeight) break;
        }

        //generate city
        float seed = Random.Range(0, 100); // 33
        Debug.Log(seed);
        for (int h = 0; h < mapHeight; h++)
        {
            for (int w = 0; w < mapWidth; w++)
            {
                int result = mapgrid[w, h];
                Vector3 pos = new Vector3(w * buildingFootprint, 0, h * buildingFootprint);

                if (result < -2)
                    Instantiate(crossroad, pos, crossroad.transform.rotation);
                else if (result < -1)
                    Instantiate(xstreets, pos, xstreets.transform.rotation);
                else if (result < 0)
                    Instantiate(zstreets, pos, zstreets.transform.rotation);
                else if (result < 2)
                    Instantiate(buildings[0], pos, Quaternion.identity);
                else if (result < 4)
                    Instantiate(buildings[1], pos, Quaternion.identity);
                else if (result < 5)
                    Instantiate(buildings[2], pos, Quaternion.identity);
                else if (result < 6)
                    Instantiate(buildings[3], pos, Quaternion.identity);
                else if (result < 7)
                    Instantiate(buildings[4], pos, Quaternion.identity);
                else if (result < 10)
                    Instantiate(buildings[5], pos, Quaternion.identity);

            }
        }
    }
}