using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlFlow : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        // Ȯ���� 10%�� �α׿� '��û'�� �̾Ҵ�!
        // Ȯ���� 20%�� �α׿� '��'�� �̾Ҵ�!
        // ������ 70% Ȯ���� 'ġġ'�� �̾ƹ��ȴ�!

        int randomValue = Random.Range(1, 101); // 1�̻� 101 �̸��� ������ ���� �޾� ���ڴ�. (1~100)

        Debug.Log($"������ ���� : {randomValue} �Դϴ�.");

        if (randomValue <= 10) // 1 ~ 10
        {
            Debug.Log("'��û'�� �̾Ҵ�!");
        }
        else if (randomValue <= 30) // 11 ~ 30
        {
            Debug.Log("'��'�� �̾Ҵ�!");
        }
        else
        {
            Debug.Log("'ġġ'�� �̾ƹ��ȴ�!");
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
