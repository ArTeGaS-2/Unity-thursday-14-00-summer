using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class Economy : MonoBehaviour
{
    public int baseClickPlusPrice = 15; // ������ ���� �� +1 �� ����
    public int clickPlusPriceMod = 15; // ����������� ������� �� +1 �� ����
    private int clickPlusBuyCounter = 0; // ʳ������ �������� ��������� ����

    public int baseAutoClickPlusPrice = 30; // ������ ���� �� +1 �� ��������
    public int autoClickPlusPriceMod = 30; // ����������� ������� �� +1 �� ��������
    private int autoClickPlusBuyCounter = 0; // ʳ������ �������� ��������� ��������

    public TextMeshProUGUI baseClickPlusPriceText; // ����� �������
    public TextMeshProUGUI clickBuyCounter; // ���������� �� �������� �������� ������

    public TextMeshProUGUI baseAutoClickPlusPriceText;
    public TextMeshProUGUI autoClickBuyCounter;
    private void Start()
    {
        // ��������� ������ ��������� � ���� ��������� ����
        UpdatePriceText();
        UpdateBuyCounter();
        // ��������� ������ ��������� � ���� ��������� ����-����
        UpdateAutoPriceText();
        UpdateAutoBuyCounter();
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
            // ��������� �������� 
            Base_Click_Loop.Instance.UpdateClickText();
            // ���� ������� �� ������� ������ �� ��� 
            Base_Click_Loop.Instance.AddCoinPerClick();
            // ���� ������� �� ��������� �������� ��������� ����
            clickPlusBuyCounter++;
            // ������� ����� � ����� �� �����
            UpdatePriceText();
            // ������� ����� � �������� �������� ������ +1 �� ���� 
            UpdateBuyCounter();
        }
    }
    public void BuyPlusOneAutoClick()
    {
        if (TakeCurrentAutoClickPrice() <= Base_Click_Loop.Instance.coinsCounter)
        {
            Base_Click_Loop.Instance.coinsCounter -= TakeCurrentAutoClickPrice();
            Base_Click_Loop.Instance.UpdateClickText();
            autoClickPlusBuyCounter++;
            UpdateAutoPriceText();
            UpdateAutoBuyCounter();
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
    private void UpdateAutoPriceText()
    {
        baseAutoClickPlusPriceText.text = "ֳ��: " +
            TakeCurrentAutoClickPrice().ToString();
    }
    private void UpdateAutoBuyCounter()
    {

        autoClickBuyCounter.text = "����� �� �������: " +
            Base_Click_Loop.Instance.coinsPerAutoClick;
    }
    private int TakeCurrentPrice()
    {
        int currentPrice = baseClickPlusPrice + 
            clickPlusBuyCounter * clickPlusPriceMod;
        return currentPrice;
    }
    private int TakeCurrentAutoClickPrice()
    {
        // ������ ������� ����, ������� ������ ���� +������� ������� +�����������
        int currentPrice = baseAutoClickPlusPrice +
            autoClickPlusBuyCounter * autoClickPlusPriceMod;
        return currentPrice;
    }
}
