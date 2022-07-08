using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjectionByProp
{
    //service interface
    public interface service
    {
        void Show();
    }

    //service class
    public class MyService : service
    {
        public void Show()
        {
            Console.WriteLine("Here is dependecy injection Example with Property");
        }
    }

    //class Client
    public class Client
    {
        private service obj;

        public service MyProperty 
        {
            get { return obj; }
            set { obj = value; }
        }
    }

    //injector class
    internal class Program
    {
        static void Main(string[] args)
        {


            Client obj = new Client();
            obj.MyProperty = new MyService(); //injecting through proprty
            obj.MyProperty.Show();




            Console.ReadLine();
        }
    }
}
