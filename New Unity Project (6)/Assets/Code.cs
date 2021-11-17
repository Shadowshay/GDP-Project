using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Code : MonoBehaviour
{
    public int cash = 1000;
    public int netWorth = 1000; 
    public int daysPassed = 0;
    public TMPro.TextMeshPro Date ;

    // number of unit of stocks for each stock pattern
    int goodStock = 0;
    int badStock = 0;
    int averageStock = 0;

    // value of stock 
    int goodStockValue = 0;
    int badStockValue = 0;
    int averageStockValue = 0;

    void nextDay()
    {

        daysPassed += 1;
        Date.SetText("Days Passed: " + daysPassed);
    }

    void calculateEarnings()
    {
        if (Random.Range(-1, 2) > 0)
        {
            int increase = Random.Range(1, 10) * 1 / 100 * goodStockValue;
            goodStockValue += Random.Range(1, 10) * 1 / 100 * goodStockValue;
            netWorth += increase * goodStock ;
        }
        else
        {
            netWorth -= goodStockValue * goodStock * Random.Range(1, 10) * 1 / 100;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
