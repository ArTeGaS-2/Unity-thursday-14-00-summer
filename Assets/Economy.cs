using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Economy : MonoBehaviour
{
    public int baseClickPlusPrice = 15; // ������ ���� �� +1 �� ����
    public int clickPlusPriceMod = 15; // ����������� ������� �� +1 �� ����
    private int clickPlusBuyCounter = 0; // ʳ������ �������� ��������� ����

    public void BuyPlusOneClick()
    {
        if (baseClickPlusPrice >= Base_Click_Loop.Instance.coinsCounter)
        {

        }
    }
}
