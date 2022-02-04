using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace PizzaHouse
{
    class PizzaLinkedListListed
    {
        public PizzaLinkedList first { get; set; }//dizinin ilk elemanı
        public PizzaLinkedList last { get; set; }//dizinin son elemanı

        public void pushback(string Pizzadata)//sondan ekleme işlemi
        {
            PizzaLinkedList newNode = new PizzaLinkedList(Pizzadata);//yeni bir veri yeni bir düğüm
            newNode.NextPizza = null;//sondaki veri olduğu için bundan sonra veri olmayacağını belirtir.

            if(first==null)// ilk veri boş ise yani dizi boş ise verinin dizinin ilk elemanı olduğunu bilmeliyiz.
            {
                first = newNode;
                first.PreviousPizza = null;//ilk elemandan öncesi yok.
                last = newNode;// bu düğüm baş olamkla birlikte tek düğüm olduğundan son elemandırda.

            }

            else//null değilse bu elemandan önce eleman var demektir.
            {
                last.NextPizza = newNode;
                newNode.PreviousPizza = last;
                last = newNode;

            }

        }


        public void pushFront(string Pizzadata)//önden ekleme.
        {
            PizzaLinkedList newNode = new PizzaLinkedList(Pizzadata);
            if(first==null)//dizi boş ise : 
            {
                first = newNode;
                last = null;

            }

            else //boş değilse
            {
                first.PreviousPizza = newNode;//ilkine yeni koyacağımız geleceği için böyle yapıyoruz
                newNode.NextPizza = first;//ve en başta ilk olan elemanımız şimdi ikinci elemanımız oluyor.
                newNode.PreviousPizza = null;//newnode yeni ilk elemanımız olduğu için onun öncesi yoktur yani null.
                first = newNode;

            }

        }


        public void RemoveFromTheEnd()//sondan veri silmek için
        {
            if (last != null)
            {
                last = last.PreviousPizza;//yeni son olan veri eski sondan bir önceki veridir
                last.NextPizza = null;//yeni sondan sonrada veri olmayacağı için null
            }

        }

        public void RemoveFromFirst()//baştan veri silmek için
        {
            if (first != null)
            {
                first = first.NextPizza;//yeni ilk eski ilkten bir sonraki olur
            }
            
        }

        public int RemoveData(string PizzaData)//silmek istediğimiz veriyi belirtip siliyoruz.
        {
            PizzaLinkedList A = first;
            while (A != null && A.PizzaData != PizzaData)
            {
                A = A.NextPizza;
            }

            if(A==null)
             {
                    return 0;
             }

            if (A.PreviousPizza == null)//silme işlemi başta ise
             {
                    RemoveFromFirst();
             }

            else if (A.NextPizza == null)//silme işlemi sonda ise
             {
                    RemoveFromTheEnd();
             }

            else
             {
                    A.NextPizza.PreviousPizza = A.PreviousPizza;//Arada ise silme işlemi
                    A.PreviousPizza.NextPizza = A.NextPizza;
             }
                
            
            return 1;
        }

        public void PrintLinkedList(ListBox my)
        {
            PizzaLinkedList A=first;
            my.Items.Clear();//Yeni eleman sonradan geldiğinde güncel olması için içeriği silip tekrar yazdırma yaptırtıyoruz.
            while (A!=null)
            {
                my.Items.Add(A.PizzaData);
                A = A.NextPizza;
            }

            
            
        }

    }
}
