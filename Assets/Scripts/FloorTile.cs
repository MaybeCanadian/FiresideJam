using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FloorTile : MonoBehaviour
{
    public Vector2 gridPos;

    private void OnMouseDown()
    {
        Debug.Log(gridPos);
    }

    public void DestroyTile()
    {

    }
}
