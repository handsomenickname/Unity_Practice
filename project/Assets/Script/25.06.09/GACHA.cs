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

    string[] character = { "정은교", "김한나", "손석현", "이윤호", "엄지성", "박현아", "차정훈", "최현석" };
    List<string> characterList = new List<string>();

    public void ArrayGacha() // character.Length
    {
        int randomValue = Random.Range(0, character.Length); // 8 , 0 ~ 7

        Debug.Log("범인은? " + character[randomValue] + "님 였습니다.");
        Txt_Bumin.text = "범인은? " + character[randomValue] + "님 였습니다.";
    }

    public void ListGacha() // characterList.Count
    {
        int randomValue = Random.Range(0, characterList.Count);  // 8 , 0 ~ 7
        Txt_Bumin.text = "범인은? " + characterList[randomValue] + "님 였습니다.";
    }


    // Update is called once per frame
    void Update()
    {
        
    }
}
