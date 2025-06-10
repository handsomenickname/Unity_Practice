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
        // string 변수의 값을 초기화 합니다.
        //string star;
        //star = string.Empty;

        // 2. 별, 빈칸, 줄바꿈 추가하기
        // Debug.Log를 사용하여 콘솔창에 출력합니다
        //star += "★"; // 별
        //star += "　"; // 빈칸
        //star += "\n"; // 줄바꿈

        // 3. Debug.Log("");
        // Debug.Log를 사용하여 콘솔창에 출력합니다
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

        // 페이즈 1

        // 별 추가 (1 ~ 5)
        for (int i = 1; i <= 5; i++) // 줄 수: 1 ~ 5
        {
            for (int j = 1; j <= i; j++) // 별 개수
            {
                star += "★";
            }
            star += "\n"; // 줄바꿈
        }

        Debug.Log(star);
    }


    public void Phase2()
    {
        star = string.Empty;

        // 페이즈 2
        int Lines = 5;

        for (int i = 1; i <= Lines; i++) // 1줄 ~ 5줄
        {
            //  앞에 들어갈 빈칸
            for (int j = 0; j < Lines - i; j++)
            {
                star += "　"; 
            }

            // 별 출력
            for (int k = 0; k < i; k++)
            {
                star += "★";

            }
            //  줄바꿈
            star += "\n";
        }   
            Debug.Log(star);
        
    }

    public void Phase3()
    {
        star = string.Empty;
        int Lines = 5;
        // 페이즈 3

        // 별 추가 (1 ~ 5)
        for (int i = 1; i <= Lines; i++) // 줄 수: 1 ~ 5
        {
            for (int j = 1; j <= i; j++) // 별 개수
            {
                star += "★";
            }
            star += "\n"; // 줄바꿈
        }

        for (int i = Lines-1; i >= 1; i--)
        {
            for (int j = 1; j <= i; j++) // 별 개수
            {
                star += "★";
            }
            star += "\n"; // 줄바꿈
        }

        Debug.Log(star);
    }

    public void Phase4()
    {
        star = string.Empty;
        int Lines = 5;
        // 페이즈 4

        for (int i = 1; i <= Lines; i++) // 1줄 ~ 5줄
        {
            //  앞에 들어갈 빈칸
            for (int j = 0; j < Lines - i; j++)
            {
                star += "　";
            }

            // 별 출력
            for (int k = 0; k < i; k++)
            {
                star += "★";

            }
            //  줄바꿈
            star += "\n";
        }

        for (int i = Lines - 1; i >= 1; i--)
        {
            //  앞에 들어갈 빈칸
            for (int j = 0; j < Lines - i; j++)
            {
                star += "　";
            }

            // 별 출력
            for (int k = 0; k < i; k++)
            {
                star += "★";

            }
            //  줄바꿈
            star += "\n";
        }
        Debug.Log(star);
    }

    public void Phase5()
    {
        star = string.Empty;

        // 페이즈 5

        int Lines = 5; // 꼭대기까지의 줄 수 (전체 줄 수는 2 * Lines - 1)

        // 위 삼각형 (1, 3, 5, 7, 9)
        for (int i = 1; i <= Lines; i++)
        {
            int Space = Lines - i; // 공백 수
            int Star = 2 * i - 1;       // 별 개수 (홀수)

            // 공백
            for (int j = 0; j < Space; j++)
            {
                star += "　";
            }

            // 별
            for (int k = 0; k < Star; k++)
            {
                star += "★";
            }

            star += "\n";
        }

        // 아래 삼각형 (7, 5, 3, 1)
        for (int i = Lines - 1; i >= 1; i--)
        {
            int Space = Lines - i;
            int Star = 2 * i - 1;

            // 공백
            for (int j = 0; j < Space; j++)
            {
                star += "　";
            }

            // 별
            for (int k = 0; k < Star; k++)
            {
                star += "★";
            }

            star += "\n";
        }


        Debug.Log(star);
    }

}
