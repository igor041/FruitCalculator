using System;
using FruitCalculator.Services;
using FruitCalculator.Models;

// Problem: Fruit calculator
// We have an application that takes as an input some fruits and their prices, promotions applicable and a basket. The output is the total price.

// Example 1:
// Input : Oranges – $10; Apples- $5 ; Promotions: No; Basket: Oranges - 5, Apples 1
// Output: Total price= 55 

// Example 2:
// Input : Oranges – $10; Apples- $5 ; Promotions: Oranges – 0.5;  Basket: Oranges - 5, Apples 1
// Output: Total price= 30


namespace FruitCalculator.Main
{
    class Program
    {
        static void Main(string[] args)
        {
            FruitCalculatorService _service = new FruitCalculatorService();
            // Scenario 1
            _service.basket.contents.Add(new Tuple<Fruit, int>(new Fruit("Oranges", 10, 0), 5));
            _service.basket.contents.Add(new Tuple<Fruit, int>(new Fruit("Apples", 5, 0), 5));
            Console.WriteLine("Total1: " + _service.basket.GetTotalPrice());
            // Scenario 2
            _service.basket.ClearBasket();
            _service.basket.contents.Add(new Tuple<Fruit, int>(new Fruit("Oranges", 10, 0.5f), 5));
            _service.basket.contents.Add(new Tuple<Fruit, int>(new Fruit("Apples", 5, 0), 5));
            Console.WriteLine("Total2: " + _service.basket.GetTotalPrice());
        }
    }
}