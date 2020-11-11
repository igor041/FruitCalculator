namespace FruitCalculator.Models{   

    public class Fruit{

        public Fruit(string type, float unitPrice, float discount )
        {
            this.type = type;
            this.unitPrice = unitPrice;
            this.discount = discount;
        }

        public string type {get;set;}
        public float unitPrice {get;set;}
        public float discount {get;set;}

    }
}