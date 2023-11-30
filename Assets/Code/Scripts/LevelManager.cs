using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManager : MonoBehaviour
{
    public static LevelManager main;

    public Transform startPoint;
    public Transform[] path;

    public int currency1;
    public int currency2;

    private void Awake()
    {
        main = this;
    }

    private void Start()
    {
        currency1 = 2;
        //currency2 = 0;
    }

    public void IncreaseCurrency1(int amount1)
    {
        currency1 += amount1;
    }

    //public void IncreaseCurrency2(int amount2)
    //{
    //    currency2 += amount2;
    //}

    public bool SpendCurrency1(int amount1)
    {
        if (amount1 <= currency1)
        {
            //Buy ITEM
            currency1 -= amount1;
            return true;
        } else
        {
            Debug.Log("Lack of Love");
            return false;
        }
    }

    //public bool SpendCurrency2(int amount2)
    //{
    //    if (amount2 <= currency2)
    //    {
    //        //Buy ITEM
    //        currency2 -= amount2;
    //        return true;
    //    }
    //    else
    //    {
    //        Debug.Log("Lack of Love");
    //        return false;
    //    }
    //}
}
