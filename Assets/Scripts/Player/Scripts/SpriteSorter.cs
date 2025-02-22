using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpriteSorter : MonoBehaviour
{
    //���� ������ ���������� ���������� �������� ������, ������� ������ �������� ������, ����������� �� ���� ���������
    public float offset = 0;
    private int sortingOrderBase = 0;
    private Renderer renderer;

    private void Avake()
    {
        renderer = GetComponent<Renderer>();
    }

    // Update is called once per frame
    private void LateUpdate()
    {
        renderer.sortingOrder = (int)(sortingOrderBase - transform.position.y + offset); //���� ��������� ������ ����� -1 ������������ ������, ���� �� ����� � ������� ���� ������
        //����� ������� ������������ ������� ������� �������� ���������
    }
}
