using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public enum Rarity
{
    R,
    SR,
    SSR,
    SSSR,
    SSSSR
}

[System.Serializable]
public class Character
{
    public string name;
    public Rarity rarity;
}

public class GachaTest : MonoBehaviour
{
    [Header("캐릭터 풀")]
    public List<Character> characterPool;


    [Header("등급별 확률 (%)")]
    public float prob_R = 60.59f;
    public float prob_SR = 26f;
    public float prob_SSR = 10.4f;
    public float prob_SSSR = 3f;
    public float prob_SSSSR = 0.01f;

    [Header("천장 시스템")]
    private int drawsSinceLastSSSSR = 0;
    private const int PITY_THRESHOLD = 50;

    private int drawButtonClickCount = 0;

    void Start()
    {

    }

    public TextMeshProUGUI resultText; // 텍스트 필드 연결

    public void DrawTenCharacters()
    {

        drawButtonClickCount++; // 버튼 누른 횟수 증가

        bool forcePityThisTime = (drawButtonClickCount >= 100); // 100번째 클릭에 천장 강제 발동
        if (forcePityThisTime) drawButtonClickCount = 0;

        string result = "";
        for (int i = 0; i < 10; i++)
        {
            Character c;
            if (forcePityThisTime && i == 9)
            {
                // 마지막 1장은 SSSSR 확정
                List<Character> pityPool = characterPool.FindAll(ch => ch.rarity == Rarity.SSSSR);
                c = pityPool[Random.Range(0, pityPool.Count)];
                drawsSinceLastSSSSR = 0;
            }
            else
            {
                c = DrawOneCharacter();
                if (c.rarity == Rarity.SSSSR)
                    drawsSinceLastSSSSR = 0;
                else
                    drawsSinceLastSSSSR++;
            }

            result += $"{c.name} ({c.rarity})\n";
        }

        resultText.text = result; // 결과를 UI에 출력
    }

    private Character DrawOneCharacter()
    {
        // 천장 발동
        if (drawsSinceLastSSSSR >= PITY_THRESHOLD)
        {
            List<Character> pityPool = characterPool.FindAll(c => c.rarity == Rarity.SSSSR);
            drawsSinceLastSSSSR = 0;
            return pityPool[Random.Range(0, pityPool.Count)];
        }

        float rand = Random.Range(0f, 100f);
        float cumulative = 0f;

        cumulative += prob_SSSSR;
        if (rand < cumulative) return GetRandomCharacterByRarity(Rarity.SSSSR);

        cumulative += prob_SSSR;
        if (rand < cumulative) return GetRandomCharacterByRarity(Rarity.SSSR);

        cumulative += prob_SSR;
        if (rand < cumulative) return GetRandomCharacterByRarity(Rarity.SSR);

        cumulative += prob_SR;
        if (rand < cumulative) return GetRandomCharacterByRarity(Rarity.SR);

        return GetRandomCharacterByRarity(Rarity.R);
    }

    private Character GetRandomCharacterByRarity(Rarity rarity)
    {
        List<Character> filtered = characterPool.FindAll(c => c.rarity == rarity);
        return filtered[Random.Range(0, filtered.Count)];
    }
}




