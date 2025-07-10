using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Economy : MonoBehaviour
{
    public int baseClickPlusPrice = 15; // Базова ціна за +1 до кліку
    public int clickPlusPriceMod = 15; // Модифікатор цінника за +1 до кліку
    private int clickPlusBuyCounter = 0; // Кількість купленик покращень кліку

    public void BuyPlusOneClick()
    {
        if (baseClickPlusPrice >= Base_Click_Loop.Instance.coinsCounter)
        {

        }
    }
}
