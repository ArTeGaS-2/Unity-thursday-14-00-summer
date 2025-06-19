using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro; // Імпорт TextMeshPro

public class Base_Click_Loop : MonoBehaviour
{
    // public - Модифікатор доступу. Дає змінній видимість в скриптах
    // та у редакторі Unity.

    // TextMeshProUGUI - Тип даних, що відповідає об'єкту тексту на сцені.

    // coinsText - назва змінної. Ми її обираємо самі.
    public TextMeshProUGUI coinsText; // Текстовий об'єкт на сцені

    // private - Зворотнє до public

    // int - Тип даних, що є цілим числом.
    private int coinsCounter = 0; // Лічильник валюти
    public void AddCoin()
    {
        coinsCounter++; // Додає одиницю до лічильника
        coinsText.text = $"Шекелі: {coinsCounter}"; // Оновлює текст
    }
    private void Start()
    {
        coinsText.text = $"Шекелі: {coinsCounter}"; // Оновлює текст
    }
}
