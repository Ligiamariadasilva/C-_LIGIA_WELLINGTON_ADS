# Estrutura inicial para o Trabalho de Lógica de Programação em C#

TRABALHO_C#_SEGUNDA
├── bin
├── Exerc_01_ValidadorSenha
│   └── Program.cs
├── Exerc_02_Tabuada
│   └── Program.cs
├── Exerc_03_Fatorial
│   └── Program.cs
├── Exerc_04_ConversorTemperatura
│   └── Program.cs
├── Exerc_05_Palindromo
│   └── Program.cs
├── Exerc_06_CadastroProdutos
│   └── Program.cs
├── Exerc_07_SomaParesArray
│   └── Program.cs
├── Exerc_08_IMC
│   └── Program.cs
├── Exerc_09_JogoAdivinhacao
│   └── Program.cs
├── Exerc_10_ToDoList
│   └── Program.cs
├── obj
├── README.md


# README.md

## Trabalho Prático – Lógica de Programação em C#

**Integrantes do grupo:**
- LIGIA MARIA DA SILVA SANTOS RGM 39106021
- WELLINGTON COQUEIRO
- NOME 3 XXXXXX

**Exercícios resolvidos:**
1. Validador de Senhas Fortes
2. Tabuada Completa com Laço
3. Cálculo de Fatorial com while
4. Conversor de Temperaturas com Menu
5. Verificador de Palíndromos
6. Cadastro Simples de Produtos
7. Soma de Números Pares de um Array
8. Cálculo de IMC com Classificação
9. Jogo da Adivinhação
10. Lista de Tarefas (To-Do List)

---

## Descrição dos Exercícios

### 1. Validador de Senhas Fortes
Valida se a senha possui no mínimo 8 caracteres, ao menos uma letra maiúscula, um número e um caractere especial.

### 2. Tabuada Completa com Laço
Recebe um número e exibe sua tabuada de 1 a 10 usando `for`.

### 3. Cálculo de Fatorial com while
Recebe um número positivo e calcula seu fatorial com laço `while`.

### 4. Conversor de Temperaturas com Menu
Apresenta um menu interativo para converter temperaturas entre Celsius e Fahrenheit com `while` e `switch`.

### 5. Verificador de Palíndromos
Verifica se a frase/palavra digitada é um palíndromo, ignorando espaços e acentos.

### 6. Cadastro Simples de Produtos
Cria uma lista de produtos com nome, preço e quantidade, e calcula o valor total em estoque.

### 7. Soma de Números Pares de um Array
Solicita 10 números e exibe a soma apenas dos pares.

### 8. Cálculo de IMC com Classificação
Recebe peso e altura, calcula o IMC e classifica o resultado.

### 9. Jogo da Adivinhação
Gera um número aleatório de 1 a 100. O jogador tenta adivinhar com dicas "maior/menor" e o programa conta as tentativas.

### 10. Lista de Tarefas (To-Do List)
Permite adicionar tarefas, marcar como concluídas e exibe a lista final com status.

---

## Documentação Detalhada

### Exercício 09 – Jogo da Adivinhação

**Lógica aplicada:**
1. Geramos um número aleatório entre 1 e 100 usando `Random.Next()`.
2. Criamos um laço `while` que continua até o número ser adivinhado.
3. Após cada tentativa, informamos se o número secreto é maior ou menor.
4. Contamos quantas tentativas o jogador fez até acertar.

**Comandos e estruturas utilizadas:**
- `Random`, `int`, `while`, `if/else`, `Console.ReadLine()` e `int.Parse()`.

**Justificativas:**
O uso de `Random` permite gerar um número secreto realista. `while` foi escolhido pois o número de tentativas é indefinido, e precisamos de repetição até o usuário acertar.

---

### Exercício 10 – Lista de Tarefas (To-Do List)

**Lógica aplicada:**
1. Usamos duas listas paralelas: uma para a descrição da tarefa e outra para indicar se foi concluída.
2. O menu com `switch` permite adicionar, marcar como concluída ou sair.
3. O usuário pode marcar tarefas concluídas com base na numeração exibida.
4. Ao final, exibimos todas as tarefas com `[X]` ou `[ ]` indicando o status.

**Comandos e estruturas utilizadas:**
- `List<string>`, `List<bool>`, `switch`, `for`, `Console.WriteLine`, `int.Parse()`.

**Justificativas:**
A separação de dados em listas permite controle simples e eficiente das tarefas. O `switch` organiza o menu e facilita a navegação entre as opções.

---