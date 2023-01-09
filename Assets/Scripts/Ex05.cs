using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ex01 : MonoBehaviour
{
    public int num1, num2, num3;
    // Start is called before the first frame update
    void Start()
    {
        GetMean(num1, num2, num3);
    }

    //Function that gives the mean of three real values
    private float GetMean(float num1, float num2, float num3) {
        return (num1 + num2 + num3) / 3;
    }
}
