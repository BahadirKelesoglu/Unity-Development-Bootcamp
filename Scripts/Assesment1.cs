using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Assesment1 : MonoBehaviour
{
    int intSayi = 5;
    float  floatSayi= 3.14f;
    string stringDegiskeni = "Bahadir Kelesoglu";

    void Start()
    {
        Method1(intSayi);
        Method2(floatSayi);
        Method3(stringDegiskeni);
    }

    void Method1(int sayi)
    {
        if (sayi > 0)
        {
            Debug.Log("Method 1: İnt değişkeni pozitif.");
        }
        else
        {
            Debug.Log("Method 1: İnt değişkeni negatif veya sıfır.");
        }
    }

    void Method2(float sayi)
    {
        switch (sayi)
        {
            case 3.14f:
                Debug.Log("Method 2: Float değişkeni pi sayısına eşit.");
                break;
            default:
                Debug.Log("Method 2: Float değişkeni farklı bir değere sahip.");
                break;
        }
    }

    void Method3(string text)
    {
        int i = 0;
        while (i < 3)
        {
            Debug.Log("Method 3: " + text);
            i++;
        }
    }
}
