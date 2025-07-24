using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Economy : MonoBehaviour
{
    public int baseClickPlusPrice = 15; // Ѕазова ц≥на за +1 до кл≥ку
    public int clickPlusPriceMod = 15; // ћодиф≥катор ц≥нника за +1 до кл≥ку
    private int clickPlusBuyCounter = 0; //  ≥льк≥сть купленик покращень кл≥ку

    public TextMeshProUGUI baseClickPlusPriceText; // “екст ц≥нника

    private void Start()
    {
        UpdatePriceText();
    }
    public void BuyPlusOneClick()
    {
        // якщо (ц≥наЅазового л≥ку <=(ћенше або дор≥внюЇ) число л≥к≥в)
        if (TakeCurrentPrice() <= Base_Click_Loop.Instance.coinsCounter)
        {
            //  ≥льк≥сть кл≥к≥в
            Base_Click_Loop.Instance.coinsCounter -= // в≥дн€ти
                // базова÷≥на л≥ку + л≥чильник упленихѕокращень * модиф≥катор÷≥ни
                TakeCurrentPrice();
            Base_Click_Loop.Instance.UpdateClickText();
            Base_Click_Loop.Instance.AddCoinPerClick();
            clickPlusBuyCounter++;
            UpdatePriceText();
        }
    }
    private void UpdatePriceText()
    {
        // ќновлюЇмо ц≥ну б≥л€ кнопки
        baseClickPlusPriceText.text = "÷≥на: " +
            TakeCurrentPrice().ToString();
    }
    private int TakeCurrentPrice()
    {
        int currentPrice = baseClickPlusPrice + 
            clickPlusBuyCounter * clickPlusPriceMod;
        return currentPrice;
    }
}
