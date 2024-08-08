using System;

namespace ContrachequeApp
{
    public class Funcionario
    {
        public decimal Salario { get; set; }
        public decimal HorasExtras { get; set; }
        public decimal ValorHorasExtras { get; set; }
        public decimal AdicionalNoturno { get; set; }
        public decimal AdicionalInsalubridade { get; set; }
        public decimal AdicionalPericulosidade { get; set; }
        public decimal Comissoes { get; set; }
        public decimal BonusGratificacoes { get; set; }
        public decimal PLR { get; set; }
        public decimal AjudaCusto { get; set; }
        public decimal ValeTransporte { get; set; }
        public decimal ValeRefeicao { get; set; }
        public decimal PlanoSaudeEmpregador { get; set; }
        public decimal PlanoOdontologicoEmpregador { get; set; }
        public decimal SeguroVida { get; set; }
        public decimal AuxilioCreche { get; set; }
        public decimal AuxilioEducacao { get; set; }

        public string Nome { get; set; }
        public string Identificacao { get; set; }
        public string Cargo { get; set; }

        public decimal CalcularINSS()
        {
            decimal inss = 0;
            if (Salario <= 1412.00m)
                inss = Salario * 0.075m;
            else if (Salario <= 2666.68m)
                inss = 1412.00m * 0.075m + (Salario - 1412.00m) * 0.09m;
            else if (Salario <= 4000.03m)
                inss = 1412.00m * 0.075m + (2666.68m - 1412.00m) * 0.09m + (Salario - 2666.68m) * 0.12m;
            else if (Salario <= 7786.02m)
                inss = 1412.00m * 0.075m + (2666.68m - 1412.00m) * 0.09m
                    + (4000.03m - 2666.68m) * 0.12m + (Salario - 4000.03m) * 0.14m;

            return inss;
        }

        public decimal CalcularIRRF()
        {
            decimal baseCalculo = Salario - CalcularINSS();
            decimal irrf = 0;

            if (baseCalculo <= 2112.00m)
                irrf = 0;
            else if (baseCalculo <= 2826.66m)
                irrf = (baseCalculo - 2112.00m) * 0.075m;
            else if (baseCalculo <= 3751.06m)
                irrf = (2826.66m - 2112.00m) * 0.075m + (baseCalculo - 2826.66m) * 0.15m;
            else if (baseCalculo <= 4664.68m)
                irrf = (2826.66m - 2112.00m) * 0.075m + (3751.06m - 2826.66m) * 0.15m +
                    (baseCalculo - 3751.06m) * 0.225m;
            else
                irrf = (2826.66m - 2112.00m) * 0.075m + (3751.06m - 2826.66m) * 0.15m +
                    (4664.68m - 3751.06m) * 0.225m + (baseCalculo - 4664.68m) * 0.275m;

            return irrf;
        }

        public decimal CalcularTotalVencimentos()
        {
            return Salario + HorasExtras * ValorHorasExtras + AdicionalNoturno +
                AdicionalInsalubridade + AdicionalPericulosidade + Comissoes +
                BonusGratificacoes + PLR;
        }

        public decimal CalcularTotalDescontos()
        {
            return CalcularINSS() + CalcularIRRF() + ValeTransporte +
                PlanoSaudeEmpregador + PlanoOdontologicoEmpregador + SeguroVida;
        }

        public decimal CalcularSalarioLiquido()
        {
            return CalcularTotalVencimentos() - CalcularTotalDescontos();
        }

        public decimal CalcularFerias()
        {
            return Salario / 3;
        }

        public void ExibirContracheque()
        {
            Console.WriteLine("----- CONTRACHEQUE -----");
            Console.WriteLine($"Nome: {Nome}");
            Console.WriteLine($"Identificação: {Identificacao}");
            Console.WriteLine($"Cargo: {Cargo}");
            Console.WriteLine("");
            Console.WriteLine("Vencimentos:");
            Console.WriteLine($"Salário: R$ {Salario}");
            if (HorasExtras > 0)
                Console.WriteLine($"Horas Extras: R$ {HorasExtras * ValorHorasExtras}");
            if (AdicionalNoturno > 0)
                Console.WriteLine($"Adicional Noturno: R$ {AdicionalNoturno}");
            if (AdicionalInsalubridade > 0)
                Console.WriteLine($"Adicional de Insalubridade: R$ {AdicionalInsalubridade}");
            if (AdicionalPericulosidade > 0)
                Console.WriteLine($"Adicional de Periculosidade: R$ {AdicionalPericulosidade}");
            if (Comissoes > 0)
                Console.WriteLine($"Comissões: R$ {Comissoes}");
            if (BonusGratificacoes > 0)
                Console.WriteLine($"Bônus e Gratificações: R$ {BonusGratificacoes}");
            if (PLR > 0)
                Console.WriteLine($"Participação nos Lucros (PLR): R$ {PLR}");
            if (AjudaCusto > 0)
                Console.WriteLine($"Ajuda de Custo: R$ {AjudaCusto}");

            Console.WriteLine("");
            Console.WriteLine("Descontos:");
            Console.WriteLine($"INSS: R$ {CalcularINSS()}");
            Console.WriteLine($"IRRF: R$ {CalcularIRRF()}");
            if (ValeTransporte > 0)
                Console.WriteLine($"Vale Transporte: R$ {ValeTransporte}");
            if (ValeRefeicao > 0)
                Console.WriteLine($"Vale Refeição: R$ {ValeRefeicao}");
            if (PlanoSaudeEmpregador > 0)
                Console.WriteLine($"Plano de Saúde: R$ {PlanoSaudeEmpregador}");
            if (PlanoOdontologicoEmpregador > 0)
                Console.WriteLine($"Plano Odontológico: R$ {PlanoOdontologicoEmpregador}");
            if (SeguroVida > 0)
                Console.WriteLine($"Seguro de Vida: R$ {SeguroVida}");
            if (AuxilioCreche > 0)
                Console.WriteLine($"Auxílio Creche: R$ {AuxilioCreche}");
            if (AuxilioEducacao > 0)
                Console.WriteLine($"Auxílio Educação: R$ {AuxilioEducacao}");

            Console.WriteLine("");
            Console.WriteLine($"Salário Líquido: R$ {CalcularSalarioLiquido()}");
            Console.WriteLine($"Férias: R$ {CalcularFerias()}");
            Console.WriteLine("------------------------");
        }

        private void EscreverLinha(string texto)
        {
            Console.WriteLine(texto);
        }
    }
}
