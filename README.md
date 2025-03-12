# Jogo de Adivinha��o

![](https://i.imgur.com/6gsaAJx.gif)

## Sobre o projeto

Este � um jogo simples de adivinha��o em C#, onde o jogador tenta adivinhar um n�mero aleat�rio. A cada tentativa o jogo fornece dicas para ajudar a descobrir o n�mero certo.

## Funcionalidades

- **N�mero Secreto Aleat�rio**: No come�o do jogo, um n�mero entre 1 e 20 � sorteado para o jogador adivinhar.  
- **Modos de Dificuldade**: O jogador pode optar entre tr�s dificuldades (F�cil, M�dio e Dif�cil), que determinam a quantidade de tentativas permitidas.  
- **Respostas em Tempo Real**: A cada palpite, o jogo informa se o n�mero escolhido � maior ou menor que o n�mero secreto.

## Requisitos

- .NET SDK (recomendado .NET 8.0 ou superior) para compila��o e execu��o do projeto.

## Como usar

1. Clone o reposit�rio

```
git clone https://github.com/estevaosantosribeiro/JogoDeAdivinhacao.git
```

2. Navegue at� a pasta raiz da solu��o

```
cd jogoDeAdivinhacao
```

3. Restaure as depend�ncias

```
dotnet restore
```

4. Navegue at� a pasta do projeto

```
cd jogoDeAdivinhacao.ConsoleApp
```

5. Execute o projeto

```
dotnet run
```