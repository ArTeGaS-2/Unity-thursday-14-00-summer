using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro; // ������ TextMeshPro

public class Base_Click_Loop : MonoBehaviour
{
    public static Base_Click_Loop Instance; // ѳ������

    public IEnumerator autoRoutine; // ����� �� ������ ��������

    // public - ����������� �������. �� ����� �������� � ��������
    // �� � �������� Unity.

    // TextMeshProUGUI - ��� �����, �� ������� ��'���� ������ �� ����.

    // coinsText - ����� �����. �� �� ������� ���.
    public TextMeshProUGUI coinsText; // ��������� ��'��� �� ����

    // private - ������� �� public

    // int - ��� �����, �� � ����� ������.
    public int coinsCounter = 0; // ˳������� ������

    public int coinsPerClick = 1; // ʳ������ ������ �� ���

    public int coinsPerAutoClick = 0; // ʳ������ ������ �� ����-���
    public void AddCoin()
    {
        coinsCounter += coinsPerClick; // ���� ������� �� ���������
        coinsText.text = $"������: {coinsCounter}"; // ������� �����
    }
    public IEnumerator AddAutoCoin()
    {
        // ����, �� ������� �������� ���� ����
        while (true)
        {
            // ���� ������� ������� �������� �� ������ 
            coinsCounter += coinsPerAutoClick;
            // ����� ��������� � ������ ������� ������         
            yield return new WaitForSeconds(1f);
            // ������� ����� ��������� 
            coinsText.text = $"������: {coinsCounter}";
        }
    }
    private void Start()
    {
        Instance = this; // ����'����� ��������� �� �����
        coinsText.text = $"������: {coinsCounter}"; // ������� �����
   
        autoRoutine = AddAutoCoin();
        StartCoroutine(autoRoutine); // ������ �������
    }
    public void UpdateClickText()
    {
        coinsText.text = $"������: {coinsCounter}"; // ������� �����
    }
    public void AddCoinPerClick()
    {
        coinsPerClick++;
    }
}
