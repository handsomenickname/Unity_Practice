using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Script : MonoBehaviour
{
    string Name = "������";
    int age = 22;
    int month = 12;
    int date = 29;
    int height = 162;
    string mbti = "ISFJ";
    string hobby = "��� ����";
    string game = "������ġ";
    string food = "����";
    string major = "���������";
    string movie = "�ϻ�";


    private void Start()
    {

        Debug.Log($"�� �̸��� {Name}�Դϴ�.");
        Debug.Log($"�� ���̴� {age}�Դϴ�.");
        Debug.Log($"�� ������ {month}�� {date}�� �Դϴ�.");
        Debug.Log($"�� Ű�� {height}�Դϴ�.");
        Debug.Log($"�� MBTI�� {mbti}�Դϴ�.");
        Debug.Log($"�� ������ {major}�Դϴ�.");
        Debug.Log($"�� ��̴� {hobby}�Դϴ�.");
        Debug.Log($"���� �����ϴ� ������ {game}�Դϴ�.");
        Debug.Log($"���� �����ϴ� ������ {food}�Դϴ�.");
        Debug.Log($"���� �����ϴ� ��ȭ�� {movie}�Դϴ�.");

    }
}
