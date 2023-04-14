namespace Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Array Program");
            Console.WriteLine("Please select any one program");
            Console.WriteLine("1:Addelement\n.2BasicArray");
            int option = Convert.ToInt32(Console.ReadLine());

            switch (option)
            {
                case 1:
                    AddingElement myObj = new AddingElement();
                    myObj.AddElementFunction();
                    break;
                case 2:
                    BasicArray myObj1 = new BasicArray();
                    myObj1.Element();
                    break;
            }

           
        }
    }
}