using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace naty
{
    public class Funcionario
    {
        public string Nome { get; set; }
        public decimal Salario { get; set; }
        public decimal HorasExtras { get; set; }
        public decimal ValorHorasExtras { get; set; }

        public Funcionario(string nome, decimal salario, decimal horasExtras, decimal valorHorasExtras)
        {
            Nome = nome;
            Salario = salario;
            HorasExtras = horasExtras;
            ValorHorasExtras = valorHorasExtras;
        }

        public Funcionario()
        {

        }

        public decimal CalcularDecimoTerceiro()
        {
            return Salario;
        }

        public decimal CalcularFerias()
        {
            return Salario + (Salario / 3);
        }

        public decimal CalcularSalarioTotal()
        {
            return Salario + (HorasExtras * ValorHorasExtras);
        }

        public void ExibirContracheque()
        {
            Console.WriteLine($"Nome: {Nome}");
            Console.WriteLine($"Salário: {Salario:C}");
            Console.WriteLine($"Horas Extras: {HorasExtras}h");
            Console.WriteLine($"Valor Horas Extras: {ValorHorasExtras:C}");
            Console.WriteLine($"Salário Total: {CalcularSalarioTotal():C}");
            Console.WriteLine($"Décimo Terceiro: {CalcularDecimoTerceiro():C}");
            Console.WriteLine($"Férias: {CalcularFerias():C}");
        }
    }
}
