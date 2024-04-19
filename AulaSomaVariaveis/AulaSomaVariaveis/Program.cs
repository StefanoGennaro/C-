// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
// PARSE É IGUAL A ANALISAR 
int num1, num2;
string operaçao;

Console.WriteLine("Ola vamos realizar operaçoes aritmeticas!");
Console.WriteLine("Digite um numero");
    num1 = int.Parse(Console.ReadLine());
Console.WriteLine("Digite um outro numero");
    num2 = int.Parse(Console.ReadLine());

Console.WriteLine("Qual tipo de operaçao vc deseja realizar?");
Console.WriteLine("adiçao");
Console.WriteLine("multiplicaçao");
Console.WriteLine("subtraçao");
Console.WriteLine("divisao");

operaçao = (Console.ReadLine());

if (operaçao == "adiçao"){
    int adiçao = num1 + num2;
    Console.WriteLine(adiçao);
}    
else if(operaçao == "multiplicaçao" ){
    int multiplicaçao = num1 * num2;
    Console.WriteLine(multiplicaçao);
}
else if(operaçao =="subtraçao"){
    int subtraçao = num1 - num2;
    Console.WriteLine(subtraçao);
}
else if(operaçao == "divisao"){
    float divisao = num1 / num2;
    Console.WriteLine(divisao);
}