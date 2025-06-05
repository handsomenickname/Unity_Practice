using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Script : MonoBehaviour
{
    int playerLevel = 10;

    private void Start()
    {
        name += "나의 이름은";
        name += "김철수";
        name += "입니다.";

        Debug.Log(name);

        Debug.Log("나의 레벨은" + playerLevel + "입니다.");
        Debug.Log($"나의 레벨은 {playerLevel}입니다.");

    }
}
