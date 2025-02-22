using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpriteSorter : MonoBehaviour
{
    //этот скрипт необходимо накидывать накаждый обьект, который должен скрывать игрока, накладыаясь на него визуально
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
        renderer.sortingOrder = (int)(sortingOrderBase - transform.position.y + offset); //слой отрисовки всегда будет -1 относительно обекта, если он ближе к нижнему краю экрана
        //позже сделать прозрачность обьекта который скрывает персонажа
    }
}
