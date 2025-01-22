using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Program : MonoBehaviour
{

    public Car bobby = new Car();
    public Car boody = new Car();
    public Car arkhaled = new Car();


    public List<Car> inventory = new List<Car>();

    void Start()
    {
        bobby.CountToNumber(10);

        //Debug.Log("Car is on Sale: " + bobby.Price);

        InitializeInventory();

        for (int i = 0; i < inventory.Count; i++)
        {
            Debug.Log("Old Price: " + inventory[i].Price);
            inventory[i].Price += 50;
            Debug.Log("New Price: " + inventory[i].Price);

        }
    }

    private void InitializeInventory()
    {
        inventory.Add(boody);
        inventory.Add(arkhaled);
        inventory.Add(bobby);
    }

    void Update()
    {
        
    }
}