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
    public TextMeshProUGUI clickBuyCounter; // ���������� �� �������� �������� ������

    private void Start()
    {
        UpdatePriceText();
        UpdateBuyCounter();
    }
    public void BuyPlusOneClick()
    {
        // ���� (���������������� <=(����� ��� �������) ���������)
        if (TakeCurrentPrice() <= Base_Click_Loop.Instance.coinsCounter)
        {
            // ʳ������ ����
            Base_Click_Loop.Instance.coinsCounter -= // ������
                // ������ֳ������ + ������������������������� * �����������ֳ��
                TakeCurrentPrice();
            Base_Click_Loop.Instance.UpdateClickText();
            Base_Click_Loop.Instance.AddCoinPerClick();
            clickPlusBuyCounter++;
            UpdatePriceText();
            UpdateBuyCounter();
        }
    }
    private void UpdatePriceText()
    {
        // ��������� ���� ��� ������
        baseClickPlusPriceText.text = "ֳ��: " +
            TakeCurrentPrice().ToString();
    }
    private void UpdateBuyCounter()
    {
        clickBuyCounter.text = "����� �� ���: " +
            Base_Click_Loop.Instance.coinsPerClick;

    }
    private int TakeCurrentPrice()
    {
        int currentPrice = baseClickPlusPrice + 
            clickPlusBuyCounter * clickPlusPriceMod;
        return currentPrice;
    }
}
