using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba6
{
    public partial class LinkList
    {
        
    }

    class Bench : LinkList
    {
        public int length { get; set; }      //длина

        public int width { get; set; }       //ширина

        //стоимость 

        public override string ToString()
        {

            Console.WriteLine("Данные об объекте : ");

            Console.WriteLine($"Стоимость  {Cost}");

            Console.WriteLine($"Длина : {length}");

            Console.WriteLine($"Ширина : {width}");




            return $" {length} {width} {Cost}";
        }
    }
    class Mate : LinkList  //мат
    {
        public int length { get; set; }  //длина

        public int width { get; set; }   //ширина

        public int area { get; set; }    //площадь

        //public int cost { get; set; }   //стоимость 
        public override string ToString()
        {

            Console.WriteLine("Данные об объекте : ");



            Console.WriteLine($"Длина : {length}");


            Console.WriteLine($"Ширина : {width}");

            Console.WriteLine($"Площадь : {area}");

            Console.WriteLine($"Стоимость  {Cost}");



            return $" {length} {width} {area} {Cost}";
        }
        class Program
        {
            static void Main(string[] args)
            {




                var list = new LinkList();
                LinkList bench1 = new Bench() { length = 30, width = 44, Cost = 5000 };
                list.Push(bench1);


                LinkList mate1 = new Mate() { area = 1, width = 20, length = 30, Cost = 4000 };

                LinkList mate2 = new Mate() { area = 1, width = 30, length = 30, Cost = 6000 };

                list.Push(mate1);

                list.Push(mate2);


                list.ListNodes();
                Console.WriteLine("_________________");

                list.DeleteNode(2);

                list.ListNodes();

                Console.WriteLine("_________________ Введите даипазон цены");

                var cost1 = Int32.Parse(Console.ReadLine());

                var cost2 = Int32.Parse(Console.ReadLine());
                int n = 0;
                for (int i = 0; i < list.Size; i++)
                {
                    if (list[i].Cost >= cost1 && list[i].Cost <= cost2)
                    {

                        Console.WriteLine(list[i]);
                        n++;
                    }

                }

                if (n == 0)
                    Console.WriteLine("Товаров, входящих в заданный диапазон цен не найдено ! ");

                Console.ReadKey();

                
            }
        }
    }


    enum A
    {

        a ,
        b
    }

    struct B
    {
        public int temp;
        public string str;
    }

}
