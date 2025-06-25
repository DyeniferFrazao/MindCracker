# 🧠 Mind Cracker
> Um jogo de memória que começa fofo... e termina quebrando sua mente. Desenvolvido em Unity por Dyênifer Thaís Frazão & CodeBugs Dev Team.

<div>
      <img height=400 width=370 align="center" src= "Quebra-Cabeça Mental Cósmico.png"/>
</div>

---

## 🎮 Sobre o projeto

**Mind Cracker** é um jogo 2D de memória desenvolvido com Unity para MacOS.  
O jogador deve encontrar pares de cartas em diferentes níveis de dificuldade, sendo a estética do jogo um prelúdio da loucura!

> "O que começa como um passatempo, pode se tornar um colapso sensorial."

---

## 🧩 Features

- ✅ Múltiplas dificuldades (Fácil, Médio, Difícil)
- 🎭 Fases com visuais perturbadores 
- 🔄 Cartas geradas dinamicamente com sprites embaralhados
- 🎆 Efeitos visuais e partículas
- 🔢 Estatísticas (tempo e acertos)
  
-- Acrescentar 
-🔊 Efeitos sonoros
- 🏁 Pós-jogo com as estatísticas geradas
- 💡 Lore implícita definida

---

## 🧰 Estrutura do projeto

Assets/
├── Prefabs/ # Cartas
├── Scenes/
│ ├── MainMenu.unity
│ ├── JogoFacil.unity
│ ├── JogoMedio.unity
│ ├── JogoDificil.unity
├── Scripts/
│ ├── GameManager.cs
│ ├── BoardManager.cs
│ ├── GameSettings.cs
│ ├── MenuPrincipal.cs
│ ├── TimeManager.cs
│ ├── UiController.cs
│ └── Card.cs
└── Sprites/ # Grandississimas artes utilizadas via <a>https://www.deviantart.com/</a>


---

## 🖥️ Como rodar o projeto

1. Abra o projeto no **Unity (versão 6.1 ou superior recomendada)**
2. Verifique se as cenas estão adicionadas em `File > Build Settings`
3. Rode a cena `MainMenu.unity`
4. Clique em um nível e divirta-se!
-> se preferir, `File > Build and Run`

---

## 💡 Sobre a jogabilidade

- Clique em duas cartas para revelá-las.
- Encontre os pares corretos.
- Se errar, elas viram de novo.
- Contabilizador de tempo e pares acertados abaixo do grid de cartas
- Botões no inferior na tela Reiniciam e Voltam ao menu principal, respectivamente 

---

## 👩‍💻 Autoria

Projeto criado por:

- **Dyênifer Thaís Frazão**  
  > Aluna de Ciência da Computação, tranferida no 5 semestre para Universidade de Passo Fundo

---

## 📜 Licença

Este projeto é de uso acadêmico/experimental.  
Todos os assets usados são gratuitos com licenças livres para uso não comercial.  
