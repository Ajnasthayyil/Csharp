// // //Accessing the inputs from the user 
// // Console.Write("Enter Your First Number:");
// // int number = Convert.ToInt32(Console.ReadLine());
// // Console.Write("Enter Your Second Number:");
// // int number1 = Convert.ToInt32(Console.ReadLine());

// // //Arithematic Operations 
// // Console.WriteLine( number+number1);
// // Console.WriteLine( number-number1);
// // Console.WriteLine( number*number1);
// // Console.WriteLine(number/number1);


// Console.Write("Enter Your State : ");
// string State = Console.ReadLine();

// if(State == "Kerala")
// {
//     Console.WriteLine("You can speak Malayalam");
// }   
// else if(State == "Tamilnadu")
// {
//     Console.WriteLine("You can speak Tamil");
// }
// else if(State == "Karnataka")
// {
//     Console.WriteLine("You can speak Kannada");
// }
// else
// {
//     Console.WriteLine("You can speak English");
// }


// string[] day = { "day1", "day2", "day3"};
// for(int i=0;i<=day.Length;i++)
// {
//     Console.WriteLine(day[i]);
// }

int[] number= { 5,7,3,2,10};
for(int i=0;i<=number.Length;i++)
{
    if(number[i]>=10)
    {
     Console.WriteLine(number[i]);
    }
}