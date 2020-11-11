using System.Xml.Serialization;
using System.Net.Http.Headers;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Collections.Generic;
using FruitCalculator.Services;
using FruitCalculator.Models;
using System.Linq;

// Problem: Fruit calculator
// We have an application that takes as an input some fruits and their prices, promotions applicable and a basket. The output is the total price.

// Example 1:
// Input : Oranges – $10; Apples- $5 ; Promotions: No; Basket: Oranges - 5, Apples 1
// Output: Total price= 55 

// Example 2:
// Input : Oranges – $10; Apples- $5 ; Promotions: Oranges – 0.5;  Basket: Oranges - 5, Apples 1
// Output: Total price= 30

namespace FruitCalculator.Services{

    public class FruitCalculatorService{ 

        public Basket basket { get;set; }

        public FruitCalculatorService(){
            this.basket = new Basket();
        }
    }
}