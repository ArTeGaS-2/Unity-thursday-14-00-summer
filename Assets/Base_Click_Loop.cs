using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro; // ������ TextMeshPro

public class Base_Click_Loop : MonoBehaviour
{
    // public - ����������� �������. �� ����� �������� � ��������
    // �� � �������� Unity.

    // TextMeshProUGUI - ��� �����, �� ������� ��'���� ������ �� ����.

    // coinsText - ����� �����. �� �� ������� ���.
    public TextMeshProUGUI coinsText; // ��������� ��'��� �� ����

    // private - ������� �� public

    // int - ��� �����, �� � ����� ������.
    private int coinsCounter = 0; // ˳������� ������
    public void AddCoin()
    {
        coinsCounter++; // ���� ������� �� ���������
        coinsText.text = $"�����: {coinsCounter}"; // ������� �����
    }
    private void Start()
    {
        coinsText.text = $"�����: {coinsCounter}"; // ������� �����
    }
}
