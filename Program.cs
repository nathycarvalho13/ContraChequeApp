using naty;
using Newtonsoft.Json;
using System.Xml;

var funcionario = new Funcionario();

while (true)
{
    PerguntaNome();
    PerguntaSalario();
    PerguntaTotalHorasExtras();

    if (funcionario.HorasExtras > 0)
    {
        EscreverLinha("Digite o valor das horas extras: ");
        funcionario.ValorHorasExtras = Convert.ToDecimal(Console.ReadLine());
        EscreverLinha("");
    }

    funcionario.ExibirContracheque();

    EscreverLinha("Deseja salvar o contracheque? (s/n): ");
    EscreverLinha("");

    if (Console.ReadLine().ToLower() == "s")
        SalvarContracheque(funcionario);

    EscreverLinha("Deseja cadastrar um novo contracheque? (s/n): ");
    EscreverLinha("");

    if (Console.ReadLine().ToLower() != "s")
        break;

    Console.Clear();
}

void PerguntaNome()
{
    EscreverLinha("Digite o nome do funcionário: ");
    funcionario.Nome = Console.ReadLine();
    EscreverLinha("");
}

void PerguntaSalario()
{
    EscreverLinha("Digite o salário do funcionário: ");
    funcionario.Salario = Convert.ToDecimal(Console.ReadLine());
    EscreverLinha("");
}

void PerguntaTotalHorasExtras()
{
    EscreverLinha("Digite o total de horas extras: ");
    funcionario.HorasExtras = Convert.ToDecimal(Console.ReadLine());
    EscreverLinha("");
}

void EscreverLinha(string texto) 
{
    Console.WriteLine(texto);
}


static void SalvarContracheque(Funcionario funcionario)
{
    string json = JsonConvert.SerializeObject(funcionario);
    string path = @"C:\Contracheques";
    Directory.CreateDirectory(path);
    File.WriteAllText(Path.Combine(path, $"{funcionario.Nome}_contracheque.txt"), json);
    Console.WriteLine("Contracheque salvo com sucesso!");
}