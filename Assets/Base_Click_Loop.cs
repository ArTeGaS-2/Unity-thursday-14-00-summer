using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro; // Імпорт TextMeshPro

public class Base_Click_Loop : MonoBehaviour
{
    public static Base_Click_Loop Instance; // Сінглтон

    // public - Модифікатор доступу. Дає змінній видимість в скриптах
    // та у редакторі Unity.

    // TextMeshProUGUI - Тип даних, що відповідає об'єкту тексту на сцені.

    // coinsText - назва змінної. Ми її обираємо самі.
    public TextMeshProUGUI coinsText; // Текстовий об'єкт на сцені

    // private - Зворотнє до public

    // int - Тип даних, що є цілим числом.
    public int coinsCounter = 0; // Лічильник валюти

    public int coinsPerClick = 1; // Кількість валюти за клік

    public int coinsPerAutoClick = 0; // Кількість валюти за авто-клік
    public void AddCoin()
    {
        coinsCounter += coinsPerClick; // Додає одиницю до лічильника
        coinsText.text = $"Колоди: {coinsCounter}"; // Оновлює текст
    }
    private void Start()
    {
        Instance = this; // Прив'язуємо екземпляр до змінної
        coinsText.text = $"Колоди: {coinsCounter}"; // Оновлює текст
    }
    public void UpdateClickText()
    {
        coinsText.text = $"Колоди: {coinsCounter}"; // Оновлює текст
    }
    public void AddCoinPerClick()
    {
        coinsPerClick++;
    }
}
