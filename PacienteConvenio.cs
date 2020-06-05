using System;
using System.IO;
class PacienteConvenio : Pessoa {
  protected string convenio;

  public string Pessoa{
    get {
      return pessoa;
    }
    set { 
      pessoa = value;
    }
  }
   public void CadastrarConvenio() {

        Console.WriteLine( "- Cadastro de Cliente Convenio" )

        //Console.Write("Nome: ");
        Nome = Console.ReadLine();
        Console.Write("Data de Nascimento: ");
        DataNascimento = Console.ReadLine();
        Console.Write ("Telefone: ");
        Telefone = Console.ReadLine();
        Console.Write("Email: ");
        Email = Console.ReadLine();
        Console.Write("CPF: ");
        Cpf = Console.ReadLine();
        Console.Write("Convenio: ");
        Convenio = Console.ReadLine();

        File.WriteAllText("cadastro.txt","- Cadastro de Cliente Convenio - \nNome: "+Nome + "\nData de Nascimento"+DataNascimento + "\nTelefone: " +Telefone + "\nEmail: " +Email + "\nCPF: " +Cpf + "\nConvenio: " +Convenio );
      }













}