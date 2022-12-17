namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter shoe size");
            int ShoeSize = int.Parse(Console.ReadLine());
            if (ShoeSize == 1)
            {//then

                Console.WriteLine("Tinyfoot Free");

            }
            else if (ShoeSize < 13)
            {

                Console.WriteLine("Little Markdown");
            }
            else if (ShoeSize > 13)
            {
                Console.WriteLine("Bigfoot Markup");
            
              }else{
                Console.WriteLine("Regularfoot Normal Price");
        }      //end if
               
               
               


        }
    }
}