# Jogo de Adivinhação

![](https://i.imgur.com/6gsaAJx.gif)

## Sobre o projeto

Este é um jogo simples de adivinhação em C#, onde o jogador tenta adivinhar um número aleatório. A cada tentativa o jogo fornece dicas para ajudar a descobrir o número certo.

## Funcionalidades

- **Número Secreto Aleatório**: No começo do jogo, um número entre 1 e 20 é sorteado para o jogador adivinhar.  
- **Modos de Dificuldade**: O jogador pode optar entre três dificuldades (Fácil, Médio e Difícil), que determinam a quantidade de tentativas permitidas.  
- **Respostas em Tempo Real**: A cada palpite, o jogo informa se o número escolhido é maior ou menor que o número secreto.

## Requisitos

- .NET SDK (recomendado .NET 8.0 ou superior) para compilação e execução do projeto.

## Como usar

1. Clone o repositório

```
git clone https://github.com/estevaosantosribeiro/JogoDeAdivinhacao.git
```

2. Navegue até a pasta raiz da solução

```
cd jogoDeAdivinhacao
```

3. Restaure as dependências

```
dotnet restore
```

4. Navegue até a pasta do projeto

```
cd jogoDeAdivinhacao.ConsoleApp
```

5. Execute o projeto

```
dotnet run
```