using System;

class Program {
  public static void Main (string[] args) {

  PrintPrimes(1 , 100);

  static void PrintPrimes (int numInit,int numFinish){
    while (numInit <= numFinish){
       int contador = 1;
       int  numDivExactas = 0;
       while (contador <= numInit){
         if (numInit % contador == 0){
           numDivExactas = numDivExactas +1;
           
         }
         contador = contador + 1;
       }
      if ( numDivExactas == 2){
        Console.WriteLine(numInit);
      }
      numInit = numInit + 1;
      }
  }
    }
}