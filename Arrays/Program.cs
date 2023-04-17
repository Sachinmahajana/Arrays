namespace Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Array Programs");
            Console.WriteLine("Please select any one program");
            Console.WriteLine("1:Addelement\n.2BasicArray\n.3FindMaxmin");
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
                case 3:
                    Findmaxmin myObj2 = new Findmaxmin();
                    myObj2.FindMaxMinFunction();
                    break;
            }

           
        }
    }
}