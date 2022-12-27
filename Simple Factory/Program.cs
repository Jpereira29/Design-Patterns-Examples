// See https://aka.ms/new-console-template for more information
using Design_Patterns;

Console.WriteLine("========== Pizzaria ========== \n");
Console.WriteLine("Informe a pizza (C)alabreza   (M)ussarela");

var pizzaEscolhida = Console.ReadLine().ToUpper();
try
{
    Pizza pizza = PizzaSimpleFactory.CriaPizza(pizzaEscolhida);
    pizza.Preparar();
    pizza.Assar(30);
    pizza.Embalar();
    Console.WriteLine("\nPizza concluída.");
}
catch (Exception e)
{
    Console.WriteLine("Erro: " + e.Message);
}
Console.ReadLine();