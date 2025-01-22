using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Car
{
    private float price = 100;

    private string name = "My Cool Car";

    private bool isOn;

    private int peopleAskedfortheprice = 0;

    private int specialPrice;

    private bool isBlackFriday = false;
    private bool isChristmas = true;
    private bool isAvailable = true;

    public bool IsOnSale { get => !isBlackFriday || isAvailable; set => isBlackFriday = value; }

    public float Price
    {
        get
        {
            peopleAskedfortheprice++;
            return CalculateNewPrice(price);
        }

        set
        {
            price = value;
        }

    }

    public string Name { get => name; set => name = value; }

    private float CalculateNewPrice(float price)
    {
        float newPrice = 0;

        if (isBlackFriday)
        {
            newPrice = price * 0.7f;
        }
        else if (isChristmas)
        {
            newPrice = price * 0.5f;
        }
        else
        {
            newPrice = price;
        }

        //Debug.Log("New Price: " + newPrice);
        return newPrice;

    }

    public void CountToNumber(int number)
    {
        for (int i = 0; i <= number; i++)
        {
            Debug.Log("Number: " + i);
        }

    }

}
