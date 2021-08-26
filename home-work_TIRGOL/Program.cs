using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace home_work_TIRGOL
{
    class Program
    {
        static void Main(string[] args)
        {
            //אוסף ממוין
            #region targil3
            SortedClass<int> scInt = new SortedClass<int>();
            SortedClass<double> scDouble = new SortedClass<double>();

            scInt.AddItem(5);
            scInt.AddItem(7);
            scInt.AddItem(22);
            scInt.AddItem(13);
            scInt.AddItem(2);
            scInt.AddItem(3);
            scInt.AddItem(77);
            scInt.AddItem(9);
            scInt.AddItem(10);
            scInt.AddItem(5);

            scDouble.AddItem(3.2d);
            scDouble.AddItem(5.3d);
            scDouble.AddItem(12.3d);
            scDouble.AddItem(25.8d);
            scDouble.AddItem(36.5d);
            scDouble.AddItem(3.222d);
            scDouble.AddItem(33.2d);
            scDouble.AddItem(45.5d);
            scDouble.AddItem(456.2d);
            scDouble.AddItem(123.5d);



            

            foreach (var item in scInt.MyArray)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("\n");
            Console.WriteLine("\n");

            foreach (var item in scDouble.MyArray)
            {
                Console.WriteLine(item);

            }

            #endregion

            CreateInstance<int> cip1 = new CreateInstance<int>();
            cip1.Instance = 15;


            //אוסף 
            Stack<Person> perStack = new Stack<Person>();
            perStack.Push(new Person(15));//מכניס למחסנית
            perStack.Push(new Person(25));
            perStack.Push(new Person(45));
            perStack.Push(new Person(10));

            Person p = perStack.Peek();//מסתכל למחסנית
            Person p1 = perStack.Pop();//מוציא מהמחסנית
            /////////////////////////
            //תרגיל 4 מחלקה שיוצרת מחלקות
            BuildClasses<string> a1 = new BuildClasses<string>(356982);
            Console.WriteLine(a1.id);

            a1.ResetID();
            Console.WriteLine($"the new id is {a1.id}");
            Console.WriteLine();

            // תרגיל 7
            Check<int> c1 = new Check<int>("yakir");
            c1.Print();

            Console.WriteLine(c1.Name+ "  " + c1.GetType());


            //new Queue<int>().Enqueue/שווה לPUSH
            //new Queue<int>().Dequeue/שווה לPOP
            //new Queue<int>().Count
          //סוגי רשימות
            //list
            //Dictionary

        }
    }




    class Person
    {
        public int id { get; set; }


        public Person(int id)
        {
            id = this.id;


        }

    }


    class BuildClasses<T>
    {

        public int id { get; set; }
        public BuildClasses(int id)
        {
            this.id = id;
        }

        public int ResetID()
        {
            int temp = int.Parse(Console.ReadLine());

            this.id = temp;
            return id;
        }
    
    
    
    }



    class Check<T>  
    {
        public string Name;





        public Check(string Name)
        {
          
            this.Name = Name;
        }

        public void Print()
        {
            Console.WriteLine($"The Name Is : {Name}");
            Console.WriteLine();
           // Console.WriteLine($"The Type Of The Class Is : {Check<T>}");
        }

    }
}
