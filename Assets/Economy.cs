using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Economy : MonoBehaviour
{
    public int baseClickPlusPrice = 15; // ������ ���� �� +1 �� ����
    public int clickPlusPriceMod = 15; // ����������� ������� �� +1 �� ����
    private int clickPlusBuyCounter = 0; // ʳ������ �������� ��������� ����

    public TextMeshProUGUI baseClickPlusPriceText; // ����� �������

    public void BuyPlusOneClick()
    {
        // ���� (���������������� <=(����� ��� �������) ���������)
        if (baseClickPlusPrice <= Base_Click_Loop.Instance.coinsCounter)
        {
            // ʳ������ ����
            Base_Click_Loop.Instance.coinsCounter -= // ������
                // ������ֳ������ + ������������������������� * �����������ֳ��
                baseClickPlusPrice + clickPlusBuyCounter * clickPlusPriceMod;
            Base_Click_Loop.Instance.UpdateClickText();
        }
    }
    private void UpdatePriceText()
    {
        // ��������� ���� ��� ������
        baseClickPlusPriceText.text = 
            (baseClickPlusPrice + clickPlusBuyCounter * clickPlusPriceMod).ToString();
    }
}
