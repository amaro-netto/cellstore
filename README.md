# CELLSTORE

Badges:
![C#](https://img.shields.io/badge/C%23--9b248e?labelColor=512BD4&style=for-the-badge&logo=csharp&logoColor=white)
![.NET: 9.0](https://img.shields.io/badge/.NET-9.0-9b248e?labelColor=512BD4&style=for-the-badge&logo=.net&logoColor=white)

---

### **Índice**

### 📝 **Descrição do Projeto**

Você é responsável por modelar um sistema que trabalha com celulares. Para isso, foi solicitado que você faça uma abstração de um celular e disponibilize maneiras de diferentes marcas e modelos terem seu próprio comportamento, possibilitando um maior reuso de código e usando a orientação a objetos.

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
    A[Inicio do Programa] --> B{Criar Instancias};
    B --> C[Metodos Comuns: Ligar, ReceberLigacao];
    C --> D{Chamar InstalarAplicativo};
    D --> E[Nokia: Override];
    D --> F[iPhone: Override];
    E --> G[Fim];
    F --> G;
```
---

### 🚀 **Funcionalidades e Demonstração**
#### **Principais Funcionalidades**
1.  **Abstração do Celular**: Classe base **Smartphone** que define as características e ações básicas (número, ligar, receber ligação).
2.  **Herança**: Classes **Nokia** e **Iphone** herdando o comportamento da classe Smartphone.
3.  **Polimorfismo**: Sobrescrita do método `InstalarAplicativo` em cada marca, permitindo que a ação seja realizada de maneiras diferentes (regra 3).

#### **Como funciona**
O programa cria objetos de diferentes tipos de celulares (Nokia e iPhone) a partir da mesma classe base `Smartphone` e testa suas funcionalidades comuns (Ligar, Receber Ligação) e suas funcionalidades específicas (Instalar Aplicativo).

---

### 💻 **Como Usar a Aplicação**
1.  Certifique-se de ter o **SDK do .NET 9.0** ou superior instalado.
2.  Navegue até o diretório `DesafioPOO` no terminal.
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
