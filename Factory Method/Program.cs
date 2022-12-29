// See https://aka.ms/new-console-template for more information
using Factory_Method;

Console.WriteLine("========== Pizzaria ==========\n");
Console.WriteLine("Informe o local (S)São Paulo  (R)Rio de Janeiro");
var localEscolhido = Console.ReadLine().ToUpper();

Console.WriteLine("Escolha a pizza (M)Mussarela  (C)Calabreza");
var pizzaEscolhida = Console.ReadLine().ToUpper();

try
{
	PizzaFactoryMethod pizzaria = PizzaSimpleFactory.CriarPizzaria(localEscolhido);
	var pizza = pizzaria.PizzaMontada(pizzaEscolhida);
	Console.WriteLine(pizza.Preparar());
	Console.WriteLine("\nPizza conluida com sucesso");
}
catch (Exception e)
{

	Console.WriteLine("Erro: " + e.Message);
}