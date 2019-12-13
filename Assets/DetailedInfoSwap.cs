using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class DetailedInfoSwap : MonoBehaviour
{
    //public TextMeshProUGUI descriptionText;
    public GameObject detailedInfo;
    public GameObject[] arDishes;
    public Image image;
    public Sprite[] images;
    //private readonly string[] titles = { "пирог", "кусок торта", "пицца", "торт", "бекон" };

    // Start is called before the first frame update
    void Start()
    { 
        detailedInfo.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        for (int i = 0; i < arDishes.Length; i++)
        {
            if (arDishes[i].activeSelf)
            {
                image.sprite = images[i];
                //descriptionText.SetText(titles[i]);
            }
        }
    }

    public void SwapDetInfo()
    {
        detailedInfo.SetActive(!detailedInfo.activeSelf);
    }
}
