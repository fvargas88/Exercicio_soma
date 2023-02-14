using System;

class Program {
  public static void Main (string[] args) {
    int s1 = Soma(1,3);
    
    Console.WriteLine ("O valor da soma 1 é: " + s1);

    int a= 12;
    int b= 10;
    int s2 = Soma(a,b);
    Console.WriteLine ("O valor da soma 2 é: " + s2);
    
  }

  static int Soma(int n1, int n2){
   int s= n1 + n2;
    return s;
    
  }
}