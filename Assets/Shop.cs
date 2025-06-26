using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shop : MonoBehaviour
{
    // bool - Змінна логічного типу.
    private bool shopWindowStatus = false; // Індикатор стану

    // GameObject - будь який об'єкт на сцені.
    public GameObject shopWindow; // Вікно магазину
    private void Start()
    {
        // SetActive - активує чи деактивує об'єкт на сцені
        shopWindow.SetActive(shopWindowStatus); // Декактивуємо 
    }
    public void ActivateShop()
    {

    }
}
