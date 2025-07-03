using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shop : MonoBehaviour
{
    // bool - ����� �������� ����.
    private bool shopWindowStatus = false; // ��������� �����

    // GameObject - ���� ���� ��'��� �� ����.
    public GameObject shopWindow; // ³��� ��������
    public GameObject gameWindow; // ³��� ��� 
    private void Start()
    {
        // SetActive - ������ �� �������� ��'��� �� ����
        shopWindow.SetActive(shopWindowStatus); // ����������� 
        gameWindow.SetActive(!shopWindowStatus); // ��������

    }
    public void ActivateShop()
    {
        shopWindowStatus = true; // ������� ���� ����������
    }
    public void DeactivateShop()
    {
        shopWindowStatus = false;
    }
    private void Update()
    {
        if (shopWindowStatus == true) // ���� ������� ��������
        {
            shopWindow.SetActive(true); // ������� ���� ��������
            gameWindow.SetActive(false); // �������� ���� ���
        }
        else if (shopWindowStatus == false) // �������� ��������
        {
            shopWindow.SetActive(false);
            gameWindow.SetActive(true);
        }
    }
}
