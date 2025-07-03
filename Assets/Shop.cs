using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shop : MonoBehaviour
{
    // bool - Змінна логічного типу.
    private bool shopWindowStatus = false; // Індикатор стану

    // GameObject - будь який об'єкт на сцені.
    public GameObject shopWindow; // Вікно магазину
    public GameObject gameWindow; // Вікно гри 
    private void Start()
    {
        // SetActive - активує чи деактивує об'єкт на сцені
        shopWindow.SetActive(shopWindowStatus); // Декактивуємо 
        gameWindow.SetActive(!shopWindowStatus); // Активуємо

    }
    public void ActivateShop()
    {
        shopWindowStatus = true; // Змінюємо стан індикатора
    }
    public void DeactivateShop()
    {
        shopWindowStatus = false;
    }
    private void Update()
    {
        if (shopWindowStatus == true) // Якщо магазин активний
        {
            shopWindow.SetActive(true); // вмикаємо вікно магазину
            gameWindow.SetActive(false); // вимикаємо вікно гри
        }
        else if (shopWindowStatus == false) // Зворотня перевірка
        {
            shopWindow.SetActive(false);
            gameWindow.SetActive(true);
        }
    }
}
