/******************************************************************************

Welcome to GDB Online.
GDB online is an online compiler and debugger tool for C, C++, Python, Java, PHP, Ruby, Perl,
C#, OCaml, VB, Swift, Pascal, Fortran, Haskell, Objective-C, Assembly, HTML, CSS, JS, SQLite, Prolog.
Code, Compile, Run and Debug online from anywhere in world.

*******************************************************************************/
using System;
class média {
  static void Main() {
    
    int a, b, c, s, p;
    double m;
    //a, b e c são os números pedidos
    // m=média, s=somatório, p= produtório
    
    Console.WriteLine("Digite o primeiro número");
    a=int.Parse(Console.ReadLine ());
    Console.WriteLine("Digite o segundo número");
    b=int.Parse(Console.ReadLine ());
    Console.WriteLine("Digite o terceiro número");
    c=int.Parse(Console.ReadLine ());
    
    m=(a+b+c)/3;
    s=a+b+c;
    p=a*b*c;
    
    Console.WriteLine("Média="+m);
    Console.WriteLine("Somatório="+s);
    Console.WriteLine("Produtório="+p);
  }
}


