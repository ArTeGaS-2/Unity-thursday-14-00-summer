using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class Economy : MonoBehaviour
{
    public int baseClickPlusPrice = 15; // Базова ціна за +1 до кліку
    public int clickPlusPriceMod = 15; // Модифікатор цінника за +1 до кліку
    private int clickPlusBuyCounter = 0; // Кількість куплених покращень кліку

    public int baseAutoClickPlusPrice = 30; // Базова ціна за +1 до автокліку
    public int autoClickPlusPriceMod = 30; // Модифікатор цінника за +1 до автокліку
    private int autoClickPlusBuyCounter = 0; // Кількість куплених покращень автокліку

    public TextMeshProUGUI baseClickPlusPriceText; // Текст цінника
    public TextMeshProUGUI clickBuyCounter; // Посилається на лічильник куплених бонусів

    public TextMeshProUGUI baseAutoClickPlusPriceText;
    public TextMeshProUGUI autoClickBuyCounter;
    private void Start()
    {
        UpdatePriceText();
        UpdateBuyCounter();
    }
    public void BuyPlusOneClick()
    {
        // Якщо (цінаБазовогоКліку <=(Менше або дорівнює) числоКліків)
        if (TakeCurrentPrice() <= Base_Click_Loop.Instance.coinsCounter)
        {
            // Кількість кліків
            Base_Click_Loop.Instance.coinsCounter -= // відняти
                // базоваЦінаКліку + лічильникКупленихПокращень * модифікаторЦіни
                TakeCurrentPrice();
            // Оновлюємо лічильник 
            Base_Click_Loop.Instance.UpdateClickText();
            // Додає одиницю до кількості валюти за клік 
            Base_Click_Loop.Instance.AddCoinPerClick();
            // Додає одиницю до лічильника куплених покращень кліку
            clickPlusBuyCounter++;
            // Оновлює текст з ціною на екрані
            UpdatePriceText();
            // Оновлює текст з кількістью куплених бонусів +1 до кліку 
            UpdateBuyCounter();
        }
    }
    private void UpdatePriceText()
    {
        // Оновлюємо ціну біля кнопки
        baseClickPlusPriceText.text = "Ціна: " +
            TakeCurrentPrice().ToString();
    }
    private void UpdateBuyCounter()
    {
        clickBuyCounter.text = "Колод за клік: " +
            Base_Click_Loop.Instance.coinsPerClick;

    }
    private int TakeCurrentPrice()
    {
        int currentPrice = baseClickPlusPrice + 
            clickPlusBuyCounter * clickPlusPriceMod;
        return currentPrice;
    }
    private int TakeCurrentAutoClickPrice()
    {
        int currentPrice = baseAutoClickPlusPrice +
            autoClickPlusBuyCounter * autoClickPlusPriceMod;
        return currentPrice;
    }
}
