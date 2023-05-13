using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GridManager : MonoBehaviour
{
    public  int width, height;

    public GameObject floorPrefab;

    private void Start()
    {
        for(int y = 0; y < height; y++)
        {
            for(int x = 0; x < width; x++)
            {
                Vector3 spawnPos = new Vector3(x, y, 0.0f);

                CreateTile(spawnPos, x, y);
            }
        }
    }

    private void CreateTile(Vector3 spawnPos, int x, int y)
    {
        GameObject tileObj = Instantiate(floorPrefab, transform);

        tileObj.transform.position = spawnPos;

        FloorTile tile = tileObj.AddComponent<FloorTile>();

        tile.gridPos = new Vector2(x, y);
    }
}
