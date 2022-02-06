using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GridManager : MonoBehaviour
{

    public Sprite sprite;
    public float[,] grid;
    int vertical, horizontal, columns, rows;

    // Start is called before the first frame update
    void Start()
    {
        vertical = (int)Camera.main.orthographicSize;

        horizontal = (int)(vertical * Camera.main.aspect);
        columns = horizontal * 2;
        rows = vertical * 2;
        grid = new float[columns, rows];

        Debug.Log(Camera.main.orthographicSize);

        for (int i = 0; i < columns; i++)
        {
            for (int j = 0; j < rows; j++)
            {
                grid[i, j] = Random.Range(0.0f, 1.0f);
                SpawnTile(i, j, grid[i, j]);
            }
        }

    }

    private void SpawnTile(int x, int y, float value)
    {
        GameObject g = new GameObject("X: " + x + " Y: " + y);
        g.transform.position = new Vector3(x - (horizontal - 0.5f), y - (vertical - 0.5f));
        var s = g.AddComponent<SpriteRenderer>();
        s.sprite = sprite;
        s.color = new Color(value, value, value);
    }

    // Update is called once per frame
    void Update()
    {

    }
}
