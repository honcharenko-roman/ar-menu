using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GridSizeAdjuster : MonoBehaviour
{
    public GridLayoutGroup grid;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log("Screen Width : " + Screen.width);
        //Debug.Log("Screen Height : " + Screen.height);
        //Debug.Log(grid.GetComponent<GridLayout>());
        grid.cellSize = new Vector2(Screen.width - 100, Screen.width - 100);
    }
}
