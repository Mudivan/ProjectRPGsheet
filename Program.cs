///Projeto de abstração de uma Ficha de RPG Simples.Baseada na Ficha do Sistema 3D&T

//Entrada de dados - Nome do persoganem
Console.WriteLine("Digite o nome do seu personagem");
string name = Console.ReadLine();


//Entrada de dados - Raça do personagem
Console.WriteLine("Digite a raça do seu personagem");
string race = Console.ReadLine();


//Entrada de dados - Classe do personagem
Console.WriteLine("Digite a classe do seu personagem");
string role = Console.ReadLine();

Console.WriteLine("Olá " + name + " você é um " + race + " e um " + role +  "\n");

Console.WriteLine("Agora vamos definir os atributos do seu personagem, digite um valor de 1 a 10 para cada atributo." + "\n");

//Entrada de dados - Atributos do personagem
Console.WriteLine("Digite o valor do seu atributo de Força");
int strength = int.Parse(Console.ReadLine());
Console.WriteLine("Digite o valor do seu atributo de Habilidade");
int hability = int.Parse(Console.ReadLine());
Console.WriteLine("Digite o valor do seu atributo de Constituição");
int constitution = int.Parse(Console.ReadLine());
Console.WriteLine("Digite o valor do seu atributo de Armadura");
int armor = int.Parse(Console.ReadLine());
Console.WriteLine("Digite o valor do seu atributo de Poder de Fogo");
int firepower = int.Parse(Console.ReadLine());