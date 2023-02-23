using System;  
  public class PrintTraingle  
  
  {
  
 public static void Main(string[] args)  
 
 {  
     int number, i, j, count = 1; 
     char k;
     
     Console.Write("Do you want to print a traingle(enter 'Y' for yes and 'N' for no)");
     k = char.Parse(Console.ReadLine());
   
     if(k=='Y')
     {
     Console.Write("Enter the height:");  
     number = int.Parse(Console.ReadLine());  
     count = number - 1;  
     for (j = 1; j <= number; j++)  
     {  
         #region Printing Space  
         for (i = 1; i <= count; i++)  
            {Console.Write(" ");  }
         count--;  
         #endregion  
         for (i = 1; i <= 2 * j - 1; i++)  
             {Console.Write("*");  }
         Console.WriteLine();  
     }  
     Console.ReadLine();  
     }
   
     else {
       Console.Write("okay, come back if you change your mind");
       
     }
 }   
 }