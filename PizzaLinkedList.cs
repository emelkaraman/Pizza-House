using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaHouse
{
    class PizzaLinkedList//düğüm klasıdır.
        //düğüm sınıfı her bir düğümde tutulması gereken verilerimizi barındırır.
    {
        private string pizzaData;//verilerimi tutacak bir string değişkeni
        private PizzaLinkedList nextPizza; //bir sonraki düğümü bilmemiz gerekirse
        private PizzaLinkedList previousPizza; //bir önceki düğümü bilmemiz gerekirse

        //pizzadata değişkenimizi doldurmak için constructor oluşturduk.
        public PizzaLinkedList(string PizzaData)
        {
            this.pizzaData = PizzaData;
        }

        public PizzaLinkedList PreviousPizza
        {
            get { return previousPizza; }
            set { previousPizza = value; }


        }

        public string PizzaData
        {
            get { return pizzaData; }
            set { this.pizzaData = value; }
        }

        public PizzaLinkedList NextPizza
        {
            get { return nextPizza; }
            set { this.nextPizza = value; }
        }
    }
}
