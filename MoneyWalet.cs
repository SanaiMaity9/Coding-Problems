using System;

namespace Problems
{
    public class Person{
        public static void Main(string[] args){
            Money money = new Money();
            Console.WriteLine("Enter the Number Of people");
            int NumberOfpeople = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Total Amount");
            int TotalAmount = Convert.ToInt32(Console.ReadLine());
            int[] PaidAmount = new int[NumberOfpeople];
            for(int i = 0; i < NumberOfpeople; i++){
                Console.WriteLine("person "+(i + 1)+" had paid\n");
                PaidAmount[i] = Convert.ToInt32(Console.ReadLine());
            }
            money.Calculation(NumberOfpeople,TotalAmount,PaidAmount);
        }
      }
      public class Money{
           public void Calculation(int NumberOfpeople, int TotalAmount,int[] AmountPaid){
            int[] result = new int[NumberOfpeople];
           
            int dividedMoney = TotalAmount / NumberOfpeople;
            for(int i = 0; i < NumberOfpeople; i++){
                result[i] = AmountPaid[i] - dividedMoney;
            } 
            MoneyDivision(result,dividedMoney,NumberOfpeople);
        }
          public void MoneyDivision(int[] Amount, int AmountToDivide, int NumberOfpeople){
            int[] whomToPay = new int[NumberOfpeople];
            int[] whoToPay = new int[NumberOfpeople];
            for (int i = 0; i < Amount.Length; i++)
            {
               if(Amount[i] < AmountToDivide && Amount[i] != 0){
                   whoToPay[i] = Array.IndexOf(Amount, Amount[i]) + 1;
            }
            else{
                if(Amount[i] != 0){
                whomToPay[i] = Array.IndexOf(Amount, Amount[i]) + 1;
                }
              }
            }
            for (int i = 0; i < Amount.Length; i++)  
            {
                if(whoToPay[i] != 0){
                    for(int j = 0 ; j< Amount.Length ; j++){
                        if(whomToPay[j] != 0){
                         Console.WriteLine("person "+ whoToPay[i] +" has to pay person "+ whomToPay[j]+" Amount = "+Math.Abs(Amount[i]));
                        }
                    }
                }
            }
         }
      }
   }