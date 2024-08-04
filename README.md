# ContraCheque

<h2>Este projeto foi desenvolvido por Nathália Carvalho. </h2>
<h4>O objetivo é criar um sistema de contracheque em C# que permita calcular o salário total de um funcionário, incluindo horas extras, décimo terceiro e férias, e salvar os dados em um arquivo JSON.</h4>

Tecnologias Utilizadas
•	Linguagem de Programação: C#
•	Framework: .NET Core
•	Biblioteca para JSON: Newtonsoft.Json

Estrutura do Projeto
O projeto é composto por dois arquivos principais:
1.	Funcionario.cs: Define a classe Funcionario com propriedades e métodos para calcular salários, décimo terceiro, férias e exibir o contracheque.
2.	Program.cs: Contém o método Main que gerencia a interação com o usuário, coleta dados do funcionário, calcula os valores necessários, exibe o contracheque e salva os dados em um arquivo JSON.

### Funcionalidades

- Cadastrar Funcionário
- Calcular Salário Total
- Calcular Décimo Terceiro
- Calcular Férias
- Exibir Contracheque
- Salvar Contracheque em JSON
- Cadastrar Novo Contracheque

<h4>Regras de Negócio do Sistema de Contracheque:</h4>

•	Cadastrar Funcionário:

Objetivo: Coletar os dados do funcionário necessários para calcular o contracheque.
Dados Necessários: Nome, Salário, Total de Horas Extras, Valor das Horas Extras.

•	Calcular Salário Total:

Fórmula: Salário Total = Salário Base + (Total de Horas Extras * Valor das Horas Extras).
Explicação: O salário total do funcionário é a soma do salário base e o valor total das horas extras trabalhadas.

•	Calcular Décimo Terceiro:

Fórmula: Décimo Terceiro = Salário Base.
Explicação: O décimo terceiro salário é igual ao salário base do funcionário.

•	Calcular Férias:

Fórmula: Férias = Salário Base + (Salário Base / 3).
Explicação: As férias são calculadas somando o salário base mais um adicional de 1/3 do salário base. Esse adicional é um direito trabalhista no Brasil.

•	Exibir Contracheque:

Objetivo: Mostrar todos os dados do contracheque no console.
Informações Exibidas: Nome, Salário Base, Total de Horas Extras, Valor das Horas Extras, Salário Total, Décimo Terceiro, Férias.

•	Salvar Contracheque em JSON:

Objetivo: Salvar os dados do contracheque em um arquivo JSON para armazenamento e consulta futura.
Caminho de Salvamento: C:\Contracheques
Formato do Arquivo: O nome do arquivo será o nome do funcionário seguido de _contracheque.json.

•	Cadastrar Novo Contracheque:

Objetivo: Permitir ao usuário cadastrar contracheques para vários funcionários sem precisar reiniciar o programa.
Pergunta ao Usuário: Após calcular e exibir um contracheque, o programa pergunta se o usuário deseja cadastrar um novo contracheque.
