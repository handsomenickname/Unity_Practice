using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Script : MonoBehaviour
{
    int playerLevel = 10;

    private void Start()
    {
        name += "���� �̸���";
        name += "��ö��";
        name += "�Դϴ�.";

        Debug.Log(name);

        Debug.Log("���� ������" + playerLevel + "�Դϴ�.");
        Debug.Log($"���� ������ {playerLevel}�Դϴ�.");

    }
}
