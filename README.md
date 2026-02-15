## 🧪 Desktop App – Simulação de Cenários para Testes com SpecFlow
Este repositório exemplifica a criação de testes automatizados usando SpecFlow (BDD), C# e Gherkin para simular cenários de interação com uma interface desktop

## 🎯 Objetivo do projeto
O objetivo principal é demonstrar como estruturar testes automatizados orientados por comportamento para aplicações desktop, usando SpecFlow para:
- escrever cenários legíveis (Gherkin),
- implementar passos de teste em C#,
- e simular interações com componentes da interface.

## 🚀 Tecnologias utilizadas
C# (.NET) - Linguagem de implementação
SpecFlow - Framework BDD para testes
Gherkin	- Linguagem de descrição de cenários

## ▶️ Como executar os testes
Pré-requisitos
.NET SDK instalado
Visual Studio ou VS Code

1. Clone o repositório:
   git clone https://github.com/sameabrazao/Desktop-App-Specflow.git
2. Abra a solução no Visual Studio ou com o VS Code
3. Restaure dependências
   dotnet restore
4. Execute os testes
   dotnet test

## Exemplo de cenário Gherkin
```gherkin
Scenario: Submitting form data
	Given that user  fill in their first name
	And last name 
	And telephone number
	When click in send
	Then should show "Sending Success message"
