using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;



public class StarStar : MonoBehaviour
{
    string star;
    public Button StarButton;

    void Start()
    {
        // 1. string.Empty
        // string ������ ���� �ʱ�ȭ �մϴ�.
        //string star;
        //star = string.Empty;

        // 2. ��, ��ĭ, �ٹٲ� �߰��ϱ�
        // Debug.Log�� ����Ͽ� �ܼ�â�� ����մϴ�
        //star += "��"; // ��
        //star += "��"; // ��ĭ
        //star += "\n"; // �ٹٲ�

        // 3. Debug.Log("");
        // Debug.Log�� ����Ͽ� �ܼ�â�� ����մϴ�
       // Debug.Log(star);

        Phase1();
        Phase2();
        Phase3();
        Phase4();
        Phase5();
    }

    public void Phase1()
    {
        star = string.Empty;

        // ������ 1

        // �� �߰� (1 ~ 5)
        for (int i = 1; i <= 5; i++) // �� ��: 1 ~ 5
        {
            for (int j = 1; j <= i; j++) // �� ����
            {
                star += "��";
            }
            star += "\n"; // �ٹٲ�
        }

        Debug.Log(star);
    }


    public void Phase2()
    {
        star = string.Empty;

        // ������ 2
        int Lines = 5;

        for (int i = 1; i <= Lines; i++) // 1�� ~ 5��
        {
            //  �տ� �� ��ĭ
            for (int j = 0; j < Lines - i; j++)
            {
                star += "��"; 
            }

            // �� ���
            for (int k = 0; k < i; k++)
            {
                star += "��";

            }
            //  �ٹٲ�
            star += "\n";
        }   
            Debug.Log(star);
        
    }

    public void Phase3()
    {
        star = string.Empty;
        int Lines = 5;
        // ������ 3

        // �� �߰� (1 ~ 5)
        for (int i = 1; i <= Lines; i++) // �� ��: 1 ~ 5
        {
            for (int j = 1; j <= i; j++) // �� ����
            {
                star += "��";
            }
            star += "\n"; // �ٹٲ�
        }

        for (int i = Lines-1; i >= 1; i--)
        {
            for (int j = 1; j <= i; j++) // �� ����
            {
                star += "��";
            }
            star += "\n"; // �ٹٲ�
        }

        Debug.Log(star);
    }

    public void Phase4()
    {
        star = string.Empty;
        int Lines = 5;
        // ������ 4

        for (int i = 1; i <= Lines; i++) // 1�� ~ 5��
        {
            //  �տ� �� ��ĭ
            for (int j = 0; j < Lines - i; j++)
            {
                star += "��";
            }

            // �� ���
            for (int k = 0; k < i; k++)
            {
                star += "��";

            }
            //  �ٹٲ�
            star += "\n";
        }

        for (int i = Lines - 1; i >= 1; i--)
        {
            //  �տ� �� ��ĭ
            for (int j = 0; j < Lines - i; j++)
            {
                star += "��";
            }

            // �� ���
            for (int k = 0; k < i; k++)
            {
                star += "��";

            }
            //  �ٹٲ�
            star += "\n";
        }
        Debug.Log(star);
    }

    public void Phase5()
    {
        star = string.Empty;

        // ������ 5

        int Lines = 5; // ���������� �� �� (��ü �� ���� 2 * Lines - 1)

        // �� �ﰢ�� (1, 3, 5, 7, 9)
        for (int i = 1; i <= Lines; i++)
        {
            int Space = Lines - i; // ���� ��
            int Star = 2 * i - 1;       // �� ���� (Ȧ��)

            // ����
            for (int j = 0; j < Space; j++)
            {
                star += "��";
            }

            // ��
            for (int k = 0; k < Star; k++)
            {
                star += "��";
            }

            star += "\n";
        }

        // �Ʒ� �ﰢ�� (7, 5, 3, 1)
        for (int i = Lines - 1; i >= 1; i--)
        {
            int Space = Lines - i;
            int Star = 2 * i - 1;

            // ����
            for (int j = 0; j < Space; j++)
            {
                star += "��";
            }

            // ��
            for (int k = 0; k < Star; k++)
            {
                star += "��";
            }

            star += "\n";
        }


        Debug.Log(star);
    }

}
