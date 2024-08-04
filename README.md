# ContraCheque

<h2>Este projeto foi desenvolvido por Nathália Carvalho. </h2>
<h4>Este projeto é um sistema de cálculo de contracheque que permite a entrada de dados de um funcionário, calcula impostos (INSS e IRRF), e exibe o contracheque final. O sistema também pode salvar o contracheque em um arquivo JSON.
</h4>

Tecnologias Utilizadas
•	Linguagem de Programação: C#
•	Framework: .NET Core
•	Biblioteca para JSON: Newtonsoft.Json

Estrutura do Projeto
O projeto é composto por dois arquivos principais:
1.	Funcionario.cs: Define a classe Funcionario com propriedades e métodos para calcular salários, décimo terceiro, férias e exibir o contracheque.
2.	Program.cs: Contém o método Main que gerencia a interação com o usuário, coleta dados do funcionário, calcula os valores necessários, exibe o contracheque e salva os dados em um arquivo JSON.

### Funcionalidades ###

-Entrada de Dados: Coleta informações pessoais e financeiras do funcionário, incluindo salário, horas extras, adicionais e benefícios.

-Cálculo de Impostos:
->INSS: Calcula o desconto do INSS com base nas faixas de contribuição.
->IRRF: Calcula o imposto de renda retido na fonte com base nas faixas de isenção e alíquotas.

-Cálculo de Férias: Calcula o valor das férias como um terço do salário bruto.

-Exibição do Contracheque: Mostra o contracheque detalhado, incluindo salário bruto, descontos, salário líquido e benefícios.

-Salvar em Arquivo: Salva o contracheque em um arquivo JSON no diretório especificado.

