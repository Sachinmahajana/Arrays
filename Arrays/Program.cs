namespace Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Array Programs");
            Console.WriteLine("Please select any one program");
            Console.WriteLine("1:Addelement\n2:BasicArray\n3:FindMaxmin\n4:ChangeElement\n5:FindReverse\n6:Sumofarray");
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
                case 4:
                    ChangeElement myArr = new ChangeElement();
                    myArr.ChangeElementFunction();
                    break;
                case 5:
                    FindReverse.FindReverseFunction();
                    break;
                case 6:
                    SumofArray myObj3 = new SumofArray();
                    myObj3.FindSumofArray();
                    break;
            }

           
        }
    }
}