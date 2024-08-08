using System;
using ContrachequeApp;
using Newtonsoft.Json;

class Program
{
    static void Main(string[] args)
    {
        var funcionario = new Funcionario();

        while (true)
        {
            PerguntaInformacoesEmpregado(funcionario);
            Console.Clear();
            PerguntaInformacoesContracheque(funcionario);
            Console.Clear();
            PerguntaBeneficios(funcionario);
            Console.Clear();

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
    }

    static void PerguntaInformacoesEmpregado(Funcionario funcionario)
    {
        EscreverLinha("Informações do Empregado");
        EscreverLinha("");
        EscreverLinha("Digite o nome do funcionário: ");
        funcionario.Nome = Console.ReadLine();
        EscreverLinha("Digite o número de identificação (CPF ou RG): ");
        funcionario.Identificacao = Console.ReadLine();
        EscreverLinha("Digite o cargo/função do funcionário: ");
        funcionario.Cargo = Console.ReadLine();
        EscreverLinha("");
    }

    static void PerguntaInformacoesContracheque(Funcionario funcionario)
    {
        EscreverLinha("Informações do Contracheque");
        EscreverLinha("");
        EscreverLinha("Digite o salário do funcionário: ");
        funcionario.Salario = Convert.ToDecimal(Console.ReadLine());
        EscreverLinha("Digite o total de horas extras: ");
        funcionario.HorasExtras = Convert.ToDecimal(Console.ReadLine());
        if (funcionario.HorasExtras > 0)
        {
            EscreverLinha("Digite o valor das horas extras: ");
            funcionario.ValorHorasExtras = Convert.ToDecimal(Console.ReadLine());
        }
        EscreverLinha("Digite o valor do adicional noturno: ");
        funcionario.AdicionalNoturno = Convert.ToDecimal(Console.ReadLine());
        EscreverLinha("Digite o valor do adicional de insalubridade: ");
        funcionario.AdicionalInsalubridade = Convert.ToDecimal(Console.ReadLine());
        EscreverLinha("Digite o valor do adicional de periculosidade: ");
        funcionario.AdicionalPericulosidade = Convert.ToDecimal(Console.ReadLine());
        EscreverLinha("Digite o valor das comissões: ");
        funcionario.Comissoes = Convert.ToDecimal(Console.ReadLine());
        EscreverLinha("Digite o valor dos bônus e gratificações: ");
        funcionario.BonusGratificacoes = Convert.ToDecimal(Console.ReadLine());
        EscreverLinha("Digite o valor da participação nos lucros e resultados (PLR): ");
        funcionario.PLR = Convert.ToDecimal(Console.ReadLine());
        EscreverLinha("");
    }

    static void PerguntaBeneficios(Funcionario funcionario)
    {
        EscreverLinha("Benefícios");
        EscreverLinha("");
        EscreverLinha("Digite o valor da ajuda de custo: ");
        funcionario.AjudaCusto = Convert.ToDecimal(Console.ReadLine());
        EscreverLinha("Digite o valor do vale transporte: ");
        funcionario.ValeTransporte = Convert.ToDecimal(Console.ReadLine());
        EscreverLinha("Digite o valor do vale refeição: ");
        funcionario.ValeRefeicao = Convert.ToDecimal(Console.ReadLine());
        EscreverLinha("Digite o valor do plano de saúde pago pelo empregador: ");
        funcionario.PlanoSaudeEmpregador = Convert.ToDecimal(Console.ReadLine());
        EscreverLinha("Digite o valor do plano odontológico pago pelo empregador: ");
        funcionario.PlanoOdontologicoEmpregador = Convert.ToDecimal(Console.ReadLine());
        EscreverLinha("Digite o valor do seguro de vida pago pelo empregador: ");
        funcionario.SeguroVida = Convert.ToDecimal(Console.ReadLine());
        EscreverLinha("Digite o valor do auxílio creche: ");
        funcionario.AuxilioCreche = Convert.ToDecimal(Console.ReadLine());
        EscreverLinha("Digite o valor do auxílio educação: ");
        funcionario.AuxilioEducacao = Convert.ToDecimal(Console.ReadLine());
        EscreverLinha("");
    }

    static void EscreverLinha(string texto)
    {
        Console.WriteLine(texto);
    }

    static void SalvarContracheque(Funcionario funcionario)
    {
        var contrachequeJson = JsonConvert.SerializeObject(funcionario, Formatting.Indented);
        var caminhoArquivo = "contracheque.json";
        File.WriteAllText(caminhoArquivo, contrachequeJson);
        EscreverLinha("Contracheque salvo com sucesso em " + caminhoArquivo);
    }
}
