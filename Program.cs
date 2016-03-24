using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using System.Collections;

namespace ConsoleApplication2
{
    class Program
    {
        class Customers
        {
            public string name { get; set; }
            private string forename { get; set; }
            private int customer_id { get; set; }

            public Customers(string nazwisko, string imie, int id)
            {
                this.name = nazwisko;
                this.forename = imie;
                this.customer_id = id;
            }
            public Customers()
            { }        

           
        }

        class Products
        {
            private string product_name { get; set; }
            private double price { get; set; }
            private int product_id { get; set; }


        }

        class Receipt
        {
            private double amount { get; set; }
        }

        class DataRepository
        {

            public List<Customers> klienci { get; set; }
            public Dictionary<int,Products> produkty { get; set; }
            public ObservableCollection<Receipt> paragony { get; set; }

            public void GenericTest()
            {
                klienci = new List<Customers>();
                produkty = new Dictionary<int, Products>();
                paragony = new ObservableCollection<Receipt>();

                AddObject<Customers>(klienci,new Customers());
                AddObject<int,Products>(produkty,new KeyValuePair<int,Products>());
                AddObject<Receipt>(paragony,new Receipt());
            }

            public void AddObject<T>(ICollection<T> list, T obj)
            {
                list.Add(obj);
            }

            public void AddObject<TKey,TValue>(ICollection<KeyValuePair<TKey,TValue>> list, KeyValuePair<TKey,TValue> obj)
            {
                list.Add(obj);
            }


        }




        static void Main(string[] args)
        {

            Customers Osoba_1 = new Customers("Nazwisko","",123);
            DataRepository dane = new DataRepository();
            dane.AddObject(dane.klienci,Osoba_1);
            Console.WriteLine("Hello");
            Console.ReadLine();
            
        }
    }

}
    


