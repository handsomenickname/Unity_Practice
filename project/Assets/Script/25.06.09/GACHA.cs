using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GACHA : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

public TextMeshProUGUI Txt_Bumin;

    string[] character = { "������", "���ѳ�", "�ռ���", "����ȣ", "������", "������", "������", "������" };
    List<string> characterList = new List<string>();

    public void ArrayGacha() // character.Length
    {
        int randomValue = Random.Range(0, character.Length); // 8 , 0 ~ 7

        Debug.Log("������? " + character[randomValue] + "�� �����ϴ�.");
        Txt_Bumin.text = "������? " + character[randomValue] + "�� �����ϴ�.";
    }

    public void ListGacha() // characterList.Count
    {
        int randomValue = Random.Range(0, characterList.Count);  // 8 , 0 ~ 7
        Txt_Bumin.text = "������? " + characterList[randomValue] + "�� �����ϴ�.";
    }


    // Update is called once per frame
    void Update()
    {
        
    }
}
