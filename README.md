# ♟️ AppConsoleJogoXadrez

Um simulador de jogo de xadrez robusto e escalável desenvolvido em **C#** para terminal. Este projeto foi construído aplicando os pilares da **Programação Orientada a Objetos (POO)**, como Herança, Encapsulamento, Polimorfismo e Abstração, para gerenciar as regras complexas de uma partida de xadrez.

---

## 🏗️ Estrutura do Projeto

Conforme a arquitetura do repositório, o código é dividido em camadas de responsabilidade para facilitar a manutenção e evolução:

* **📁 Tabuleiro**: Contém a "Engine" genérica de jogos de mesa. Define as classes base para `Peca`, `Posicao` e o próprio `Tabuleiro`. É uma camada independente que não conhece as regras do xadrez, apenas como gerenciar uma grade de peças.
* **📁 Xadrez**: Contém as regras de negócio específicas do Xadrez. Aqui estão as implementações de cada peça (Rei, Torre, Bispo, etc.) e a lógica da partida (`PartidaDeXadrez`).
* **📄 Tela.cs**: Responsável pela Interface de Usuário (UI). Lida com a renderização visual do tabuleiro no console, incluindo cores e a captura de comandos do teclado.
* **📄 Program.cs**: O ponto de entrada (Entry Point) da aplicação, responsável por instanciar a partida e manter o loop principal do jogo.

---

## 🚀 Funcionalidades e Regras Implementadas

O sistema suporta as regras fundamentais de uma partida profissional:

* **Movimentação Validada**: O sistema calcula os movimentos possíveis de cada peça, impedindo jogadas ilegais.
* **Sistema de Turnos**: Controle automático entre as peças brancas e pretas.
* **Peças Capturadas**: Exibição em tempo real das peças removidas do tabuleiro por cada jogador.
* **Lógica de Xeque**: Identificação automática quando o Rei está sob ataque.
* **Xeque-Mate**: Finalização da partida ao detectar que não há mais movimentos legais para salvar o Rei.
* **Jogadas Especiais**:
    * **Roque Pequeno**: Movimento de defesa entre o Rei e a Torre do lado do Rei.
    * **Roque Grande**: Movimento de defesa entre o Rei e a Torre do lado da Rainha.

---

## 🎮 Exemplo de Uso

Ao executar o programa, o tabuleiro será exibido e o jogo solicitará as coordenadas no formato de xadrez (coluna + linha).

1.  **Origem**: Digite a posição da peça que deseja mover (Ex: `e2`).
2.  **Destino**: O sistema destacará as posições possíveis. Digite a posição de destino (Ex: `e4`).
3.  O sistema validará a jogada, capturará peças se necessário e passará o turno.

**Visualização esperada no Console:**
```text
  8 R C B Q K B C R
  7 P P P P P P P P
  6 - - - - - - - -
  5 - - - - - - - -
  4 - - - - P - - -
  3 - - - - - - - -
  2 P P P P - P P P
  1 R C B Q K B C R

  a b c d e f g h

  Turno: 1
  Aguardando jogada: Brancas
```
---

## ⚙️ Como Clonar e Rodar o Projeto
Siga os passos abaixo para configurar o ambiente e executar o jogo:

1. Pré-requisitos
Ter o .NET SDK (6.0 ou superior) instalado em sua máquina.

2. Clonar o Repositório
Abra o seu terminal ou prompt de comando e execute:

```
git clone [https://github.com/seu-usuario/AppConsoleJogoXadrez.git](https://github.com/seu-usuario/AppConsoleJogoXadrez.git)
```

3. Entrar na Pasta do Projeto

```
cd AppConsoleJogoXadrez
```

4. Executar a Aplicação
Você pode rodar diretamente via terminal com o comando:

```
  dotnet run
```

*Ou, se preferir, abra o arquivo .sln no Visual Studio e pressione F5.*

---

## 🛠️ Tecnologias Utilizadas
Linguagem: C#

Plataforma: .NET Core / .NET Console Application

IDE Recomendada: Visual Studio 2022 ou VS Code

*Nota: Desenvolvido como projeto de estudo focado em Lógica de Programação e Arquitetura de Software.*
