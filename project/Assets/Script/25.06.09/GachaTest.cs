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
    [Header("ĳ���� Ǯ")]
    public List<Character> characterPool;


    [Header("��޺� Ȯ�� (%)")]
    public float prob_R = 60.59f;
    public float prob_SR = 26f;
    public float prob_SSR = 10.4f;
    public float prob_SSSR = 3f;
    public float prob_SSSSR = 0.01f;

    [Header("õ�� �ý���")]
    private int drawsSinceLastSSSSR = 0;
    private const int PITY_THRESHOLD = 50;

    private int drawButtonClickCount = 0;

    void Start()
    {

    }

    public TextMeshProUGUI resultText; // �ؽ�Ʈ �ʵ� ����

    public void DrawTenCharacters()
    {

        drawButtonClickCount++; // ��ư ���� Ƚ�� ����

        bool forcePityThisTime = (drawButtonClickCount >= 100); // 100��° Ŭ���� õ�� ���� �ߵ�
        if (forcePityThisTime) drawButtonClickCount = 0;

        string result = "";
        for (int i = 0; i < 10; i++)
        {
            Character c;
            if (forcePityThisTime && i == 9)
            {
                // ������ 1���� SSSSR Ȯ��
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

        resultText.text = result; // ����� UI�� ���
    }

    private Character DrawOneCharacter()
    {
        // õ�� �ߵ�
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




