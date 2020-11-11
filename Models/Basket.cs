using System;
using System.Collections.Generic;

namespace FruitCalculator.Models{
    public class Basket{
        public List<Tuple<Fruit, int>> contents = new List<Tuple<Fruit, int>>();

        public Basket() { }

        public float GetTotalPrice(){
            float result = 0;

            this.contents.ForEach( i => {
                result += (i.Item1.unitPrice * (1 - i.Item1.discount)) * i.Item2;
            });

            return result;
        }

        public void ClearBasket(){
            this.contents.Clear();
        }
    }
}