using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shop : MonoBehaviour
{
    // bool - ����� �������� ����.
    private bool shopWindowStatus = false; // ��������� �����

    // GameObject - ���� ���� ��'��� �� ����.
    public GameObject shopWindow; // ³��� ��������
    private void Start()
    {
        // SetActive - ������ �� �������� ��'��� �� ����
        shopWindow.SetActive(shopWindowStatus); // ����������� 
    }
    public void ActivateShop()
    {

    }
}
