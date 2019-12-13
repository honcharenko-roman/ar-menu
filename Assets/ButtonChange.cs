using UnityEngine;

public class ButtonChange : MonoBehaviour
{
    private GameObject one;
    private GameObject two;
    private GameObject three;
    private GameObject four;
    private GameObject five;

    int flag = 0;
                 
    void Start()
    {

        one = GameObject.Find("FIRST");
        two = GameObject.Find("SECOND");
        three = GameObject.Find("THIRD");
        four = GameObject.Find("FOURTH");
        five = GameObject.Find("FIFTH");
    }

    private void Update()
    {
        if (flag == 0)
        {
            flag = 1;
            two.SetActive(false);
            three.SetActive(false);
            four.SetActive(false);
            five.SetActive(false);
        }
    }
    // Функция, которая будет выполняться при нажатии на кнопку  
    public void ChangeGameObject()
    {
            if (one.active == true)
            {
            one.SetActive(false);
            two.SetActive(true);
            } else if (two.active == true)
            {
            two.SetActive(false);
            three.SetActive(true);
            }  else if (three.active == true)
            {
            three.SetActive(false);
            four.SetActive(true);
            } else if (four.active == true)
            {
            four.SetActive(false);
            five.SetActive(true);
            } else if (five.active == true)
            {
            five.SetActive(false);
            one.SetActive(true);
            } else
            {
            one.SetActive(true);
            two.SetActive(false);
            three.SetActive(false);
            four.SetActive(false);
            five.SetActive(false);
            }
    } 
}