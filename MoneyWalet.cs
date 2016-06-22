using System;

namespace Problems
{
    public class MoneyWalet{
        public static void Main(string[] args){
            MoneyWalet money = new MoneyWalet();
            int NumberOfpeople = 5;
            int TotalAmount = 1000;
            int[] PaidAmount = new int[5]{200,100,550,150,0};
            money.Calculation(NumberOfpeople,TotalAmount,PaidAmount);
        }
        
        public void Calculation(int NumberOfpeople, int TotalAmount,int[] AmountPaid){
            int result = 0;
            int dividedMoney = TotalAmount / NumberOfpeople;
            for(int i=0; i<NumberOfpeople; i++){
                result = AmountPaid[i] - dividedMoney;
                Console.WriteLine("person"+ (i+1) +" has to pay = "+result);
            } 
        }
    }
}