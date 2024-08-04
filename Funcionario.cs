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
        public string Matricula { get; set; }
        public string DataAdmissao { get; set; }
        public string Departamento { get; set; }

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

        public decimal CalcularFerias()
        {
            decimal salarioBrutoSemBeneficios = Salario + HorasExtras * ValorHorasExtras 
                + AdicionalNoturno + AdicionalInsalubridade + AdicionalPericulosidade + Comissoes + BonusGratificacoes + PLR + AjudaCusto;
            return salarioBrutoSemBeneficios / 3;
        }

        public void ExibirContracheque()
        {
            decimal salarioBruto = Salario + HorasExtras * ValorHorasExtras + 
                AdicionalNoturno + AdicionalInsalubridade + AdicionalPericulosidade 
                + Comissoes + BonusGratificacoes + PLR + AjudaCusto;
            decimal inss = CalcularINSS();
            decimal irrf = CalcularIRRF();
            decimal salarioLiquido = salarioBruto - inss - irrf;
            decimal ferias = CalcularFerias();

            Console.WriteLine("Contracheque");
            Console.WriteLine("-------------------------");
            Console.WriteLine($"Nome: {Nome}");
            Console.WriteLine($"Cargo: {Cargo}");
            Console.WriteLine($"Salário Bruto: {salarioBruto:C}");
            Console.WriteLine($"INSS: {inss:C}");
            Console.WriteLine($"IRRF: {irrf:C}");
            Console.WriteLine($"Salário Líquido: {salarioLiquido:C}");
            Console.WriteLine($"Férias: {CalcularFerias():C}");
            

            if (ValeRefeicao > 0)
                Console.WriteLine($"Auxílio Alimentação: {ValeRefeicao:C}");
            if (ValeTransporte > 0)
                Console.WriteLine($"Auxílio Transporte: {ValeTransporte:C}");
            if (PlanoSaudeEmpregador > 0)
                Console.WriteLine($"Plano de Saúde (Empregador): {PlanoSaudeEmpregador:C}");
            if (PlanoOdontologicoEmpregador > 0)
                Console.WriteLine($"Plano Odontológico (Empregador): {PlanoOdontologicoEmpregador:C}");
            if (SeguroVida > 0)
                Console.WriteLine($"Seguro de Vida: {SeguroVida:C}");
            if (AuxilioCreche > 0)
                Console.WriteLine($"Auxílio Creche: {AuxilioCreche:C}");
            if (AuxilioEducacao > 0)
                Console.WriteLine($"Auxílio Educação: {AuxilioEducacao:C}");

            Console.WriteLine("-------------------------");
        }
    }
}
