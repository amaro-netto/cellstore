# CELLSTORE

### Badges:

![C#](https://img.shields.io/badge/C%23-9b248e?labelColor=512BD4&style=for-the-badge&logo=csharp&logoColor=white)
![.NET: 9.0](https://img.shields.io/badge/.NET-9.0-9b248e?labelColor=512BD4&style=for-the-badge&logo=.net&logoColor=white)
![Status: Concluído](https://img.shields.io/badge/Status-Concluído-success?style=for-the-badge)

### **Índice**

### 📝 **Descrição do Projeto**

Este projeto é um simulador interativo de smartphones desenvolvido em **C#** e **.NET**. O objetivo principal foi modelar, de forma prática e funcional, os pilares da Programação Orientada a Objetos (POO): **Abstração, Herança e Polimorfismo**.

Através de uma interface de console, o sistema simula dois aparelhos de marcas distintas (Nokia e iPhone) que compartilham comportamentos básicos (Ligar, Receber Ligação) herdados de uma classe abstrata (`Smartphone`).

O ponto central da solução é o **Polimorfismo**, onde a ação de `InstalarAplicativo` se comporta de maneira única para cada marca (simulando a Ovi Store e a App Store). Adicionalmente, o sistema implementa um controle de memória em tempo real que diminui com a instalação de aplicativos, fornecendo *feedback* detalhado ao usuário em GB e MB.

O resultado é um sistema robusto que demonstra o **reuso de código** e a capacidade de modelar entidades complexas com diferentes comportamentos a partir de um único molde.

#### ⚙️ **Tecnologias Utilizadas**
* **C#** (Linguagem de Programação)
* **.NET 9.0** (Framework)
* **Programação Orientada a Objetos (POO)**: Abstração, Herança e Polimorfismo.

#### 📁 **Estrutura do Projeto**

```
├── .gitignore
├── DesafioPOO.csproj
├── Imagens
└── diagrama.png
├── Models
├── Iphone.cs
├── Nokia.cs
└── Smartphone.cs
├── Program.cs
└── README.md
```
#### ** Fluxo de Funcionamento**
```mermaid
graph TD
    A[Início do Sistema: dotnet run] --> B{Cria Instâncias Nokia e iPhone};
    B --> C(Loop Principal: Escolha o Celular);
    C --> D{Escolha uma Ação};
    D -- Ligar / Receber --> E[Chama métodos herdados de Smartphone];
    D -- Ver Detalhes --> F[Chama ExibirDetalhes, atualizando memória];
    D -- Instalar App --> G{Chama InstalarAplicativo - Polimorfismo};
    G --> H[Smartphone: Gerencia Memória MB/GB];
    H -- Sucesso --> I[Nokia/iPhone: Exibe mensagem de sucesso específica];
    H -- Falha --> J[Smartphone: Exibe erro de memória insuficiente];
    D -- Sair --> Z[Fim do Programa];
    E --> C;
    F --> C;
    I --> C;
    J --> C;
```
---

### 🚀 **Funcionalidades e Demonstração**
#### **Principais Funcionalidades**

**Abstração do Celular:** Classe base Smartphone que define as características (Modelo, IMEI, Memoria) e ações básicas (Ligar, Receber Ligação).

**Herança e Reuso:** Classes Nokia e Iphone utilizam a lógica centralizada de gerenciamento de memória da classe pai.

**Polimorfismo:** O método InstalarAplicativo é sobrescrito para simular o processo de instalação de cada marca (Ovi Store vs. App Store).

**Simulação de Memória:** Controle interno da memória em MB, com exibição padronizada em GB (MB), que reflete o uso após cada instalação.

#### **Como funciona**
O programa inicia um loop de menu, permitindo ao usuário escolher entre as marcas e ações. As chamadas de métodos são dinâmicas, garantindo que o comportamento polimórfico (instalação) e o estado do objeto (memória livre) sejam atualizados e refletidos em tempo real.

---

### 💻 **Como Usar a Aplicação**
1.  Certifique-se de ter o **SDK do .NET 9.0** ou superior instalado.
2.  Navegue até o diretório `cellstore` no terminal.
3.  Execute o comando para compilar e rodar o projeto:
   
    ```bash
    dotnet run
    ```

---

### 👥 **Equipe do Projeto**
<a href="https://github.com/amaro-netto" title="Amaro Netto"><img width="180" src="https://github.com/user-attachments/assets/b7a3a1bf-304a-4974-b75f-1d620ad6ecf1"/></a>
---

### ✅ **Conclusão**
O projeto demonstra o uso dos pilares da Programação Orientada a Objetos em C#, criando um sistema funcional de modelagem de celulares.

---

### 📸 **Prévia do Projeto**
