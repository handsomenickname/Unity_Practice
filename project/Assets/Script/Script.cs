using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Script : MonoBehaviour
{
    string Name = "박현아";
    int age = 22;
    int month = 12;
    int date = 29;
    int height = 162;
    string mbti = "ISFJ";
    string hobby = "밴드 연습";
    string game = "오버워치";
    string food = "삼겹살";
    string major = "산업디자인";
    string movie = "암살";


    private void Start()
    {

        Debug.Log($"제 이름은 {Name}입니다.");
        Debug.Log($"제 나이는 {age}입니다.");
        Debug.Log($"제 생일은 {month}월 {date}일 입니다.");
        Debug.Log($"제 키는 {height}입니다.");
        Debug.Log($"제 MBTI는 {mbti}입니다.");
        Debug.Log($"제 전공은 {major}입니다.");
        Debug.Log($"제 취미는 {hobby}입니다.");
        Debug.Log($"제가 좋아하는 게임은 {game}입니다.");
        Debug.Log($"제가 좋아하는 음식은 {food}입니다.");
        Debug.Log($"제가 좋아하는 영화는 {movie}입니다.");

    }
}
