//Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
/*
void ShowNumber()
{
    int n = new Random().Next(100,999);
    Console.Write(n + " -> ");
    int n3 = n/10%10;
    Console.Write(n3);
    
}

ShowNumber();


// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
void ShowNumber()
{
    Console.Write("add new number ->");
    int n = Convert.ToInt32(Console.ReadLine());
    Console.Write(n + " -> ");
    if (n < 100)
     {
        Console.Write("no third digit");
     }
     else
     {
         if(n>999)
         {
          while(n > 1000)
        {
         n = n/10;
        }
         n = n%10;
         Console.Write(n);
         }
         else
         {
            n = n%10;
         Console.Write(n); 
         }
   
}
 }
   

ShowNumber();

// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным


void ShowNumber()
{
   Console.Write("write the day of the week as a number -> ");
    int dayNumber = Convert.ToInt32(Console.ReadLine());
   if(dayNumber > 7)
   {
       Console.WriteLine("rest buddy :3");
       Console.Write("only 7 days a week");
   }
   else{
   if (dayNumber > 5)
   {
       Console.Write("cheers weekend :D");
   }
else
{
    Console.Write("not a day off :(");
} }
}
ShowNumber();
*/