using System; 
using System.Collections.Generic; 
using System.Linq; 
using System.Text;

namespace ConsoleApplication1
{
    // Описываем интерфейс     
    public interface itest
    {
        // Определяем набор абстрактных методов         
        int Test1();         
        int test2();
    }
    // Данный класс реализует интерфейс itest     
    class MyClass : itest
    {         int My_x;
    // Пример get-тера и set-тера закрытого поля x         
        public int x
        {
            set { My_x = value; }             
            get { return My_x; }         
        }         
        public MyClass() 
        {             
        }
        // Реализуем методы интерфейса itest         
        public virtual int Test1()
        {
            return 1;        
        }
        public int test2()
        {
            return 2;
        }
    }
    class Program
    {
        static void Main()
        {
            MyClass obj1 = new MyClass();
            int t1 = obj1.Test1();   
            int t2 = obj1.test2();
            Console.WriteLine("{0} {1}", t1, t2);
            Console.ReadLine();
        }
    }
}