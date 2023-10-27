<p align="center">
   <img src="http://img.shields.io/static/v1?label=STATUS&message=EM%20DESENVOLVIMENTO&color=RED&style=for-the-badge" #vitrinedev/>
</p>

##

<p align="center">
  <img width="500" height="140" alt="Balta.IO" src="https://baltaio.blob.core.windows.net/static/images/dark/balta-logo.svg">
</p>

<h1 align="center"> Curso Balta.Io - Fundamentos da orientação a Objetos. </h1>

Repositório destinado a conter exercícios e projetos do plataforma balta.io. 

Descrição do seu projeto;
Funcionalidades;
Como os usuários podem utilizá-lo;
Onde os usuários podem encontrar ajuda sobre seu projeto;
Autores do projeto.
oi



<hd>

# 02 - Fundamentos da Orientacao a Objeto

## M01A09 - Modificadores de Acesso

Utilizados para definir niveis de acesso para classes, métodos, priopriedades. “[Documentação](https://learn.microsoft.com/pt-br/dotnet/csharp/language-reference/keywords/access-modifiers)”

| Private | Define que o acesso aos dados ficaram acessiveis somente dentro da classe pai |
| --- | --- |
| Protect | Acesso limitado a classe que contém os ou aos tipos derivado da classe que as contém. |
| Internal | Acesso limitado ao namespace atual. |
| Public | Acesso não restrito. |
| Protect Internal | Acesso limitado ao assembly atual ou aos tipos derivados da classe que as contém.  |
| Private protected | O acesso limitado a classe que o contém ou a tipos derivados da classe que comtém no assembly atual. |

- Private
- Protect
- Internal
- Public

Obersarvação, classes que em por padrão são defauld, são definidas como private.

---

## M01A10 - TIPO COMPLEXOS

Tipos complexos são classes que tem internamente outros tipos de onbjeto em seus menbros

Ex:

```csharp
namespace BaltaIO 
{
	public static void main()
	{
	
		public class Pagamento()
		{
			public bool StatusPagamento{ get; set; }
			public StatusEndereco Endereco { get; set; } // Tipo Complexo
		}	
		
		// Objeto endereço, contendo seus mebros da classe.
		static void Endereco()
		{
			public bool StatusEndereco {get; set;}
			public string Endereco { get; set; }
			public string Numero { get; set; }
		}
	
	}	
}
```

---

## M01A12 - Métodos

Sobre carga do métodos, são multiplas assinaturas do método.

Ex

```csharp
public void Pagar(double valorPagamento){}

public void Pagar(double valorPagamento, DateTime dataPagamento){}

public void Pagar(double valorPagamento, DateTime dataPagamento, bool statusPagamento = true){}
```

Utilizado quando trabalhamos com herança.

Contrutor paramiters ⇒ Contrutor sem parametros.

---

## M01A13 - Using e Dispose

Using ⇒ Garante o uso correto de onbjeto de descarte.

para utilziar o Using é preciso herdar a classe [IDisposable](https://learn.microsoft.com/en-us/dotnet/api/system.idisposable?view=net-7.0):

---

## M01A14 - Classes estaticas

Classe Static não pode ser instanciada, porque quando informamos que a classe é static ela passa a ter sempre a informação em na memoria no build da aplicação.

Avantagens -

Armanezar informações na configuração da aplicação
Ex:

```csharp
//Modelo que armazena dados da apicaçao que podem ficar em memoria.
public static class Settings()
{
	public static string URL_API { get; set; }	
}
```

Sempre que a mesma informação sejá a mesma pra qualquer tipo de usuario, é o ideial a utilziação.

No exemplo do projeto Itau, podemos criar objetos static para uma chama de URL da API, STS, BP4, CA.

---

## M01A15 - Classes Seladas

Modificador sealead, utilizada para selar a classe, priobindo heranças e classes estendidas devirada dela.

---

## M01A16 - Classes parciais ⇒ Class partial

Classes parciais ⇒ Class partial, é um modificador utilziado para quando precisar criar duas classes que precisa extender uma da outra. caso raro.
Ex:

Payments.cs

```csharp
namespace Payments 
{
	public partial class Payment
	{
		//Aqui fica os =>
		//metodos
		//eventos
	}
}

```

CreditCardPayments.cs

```csharp
namespace Payments
{
	public partial class payment
	{
		//Aqui fica os => 
		//Métodos
		//Eventos
	}
}
```

---

## M01A17 - Interfaces

Interfaces é igual a um contrato, precisamos seguir o modelo de implementação como regra do contexto.

A interface é um contato de como deve ser feito, com implmentalções a ser seguidas.

---

## M01A18 - Classe abstract

Classe abstrata, é utilizada quando queremos definir que uma classe não pode ser instancia, por não fazer necessario. já que ela é a base(pai) das outras que as defivam.

Classes abstratas são implmentações que precisam ser executadas.

---

## M01A19 - Upcast e Downcast

UpCasting: O UpCasting ocorre quando você converte um objeto de uma classe derivada para uma classe base. É como se você estivesse "subindo" na hierarquia de classes. Nesse caso, não há perda de informação, pois a classe derivada possui todos os membros da classe base. Um exemplo seria converter um objeto do tipo "Cachorro" (derivado) para o tipo "Animal" (base).

DownCasting: O DownCasting ocorre quando você converte um objeto de uma classe base para uma classe derivada. É como se você estivesse "descendo" na hierarquia de classes. Nesse caso, pode ocorrer perda de informação, pois nem todos os membros da classe derivada estão presentes na classe base. Para realizar o DownCasting de forma segura, é necessário verificar se o objeto é do tipo esperado antes de fazer a conversão. Um exemplo seria converter um objeto do tipo "Animal" (base) para o tipo "Cachorro" (derivado), desde que você tenha certeza de que o objeto é realmente um cachorro.

---

## M01A20 - Comparação de Objetos.

Nessa aula foi apresentada como podemos fazer comparação de objetos, utilizando o método Equals.

Foi implementado uma interface da classe system IEquatable<>. Que implementa o método Equal no onjeto a ser comparado.

```csharp
internal class Program
{
    private static void Main(string[] args)
    {
        var ObjetoA = new Pessoa(1, "William");
        var ObjetoB = new Pessoa(1, "Stephane");

        Console.WriteLine(ObjetoA.Equals(ObjetoB));
    }

    public class Pessoa : IEquatable<Pessoa>
    {
        public Pessoa(int id, string nome)
        {
            Id = id;
            Nome = nome;
        }

        public int Id { get; set; }
        public string Nome { get; set; }

        //Tratar objeto nullable
        public bool Equals(Pessoa? pessoa) => Id == pessoa?.Id;
    }
}
```

---

## M01A21 - Delegetes

Delegates ⇒ Algo para delegar a alguem para fazer.

Também chamado de Anonymous Methods.

Regra do delegetes, é preciso de a mesma assinatura dos metodos.

---



## Desenvolvedores

| [<img src="https://avatars.githubusercontent.com/u/43853142?v=4" width=115><br><sub>William henrique cirino</sub>](https://github.com/williamWHC)
| :---:
