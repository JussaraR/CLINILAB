using System;
using System.IO;

  class PacienteConvenio: Pessoa{
    protected string convenio;

    public string Convenio{
      get{
        return convenio;
      }
      set{
        convenio = value;
      }
    }


  public void CadastrarConvenio(){
    
  Console.WriteLine("- Cadastro paciente Convenio");
  Console.Write("Nome: ");
  Nome = Console.ReadLine();
  Console.Write("Endereço: ");
  Endereco = Console.ReadLine();
  Console.Write("Telefone: ");
  Telefone = Console.ReadLine();
  Console.Write("Data de nascimento: ");
  DataNascimento = Console.ReadLine();
  Console.Write("CPF: ");
  Cpf = Console.ReadLine();
  Console.Write("Convenio: ");
  Convenio = Console.ReadLine();

 //using (System.IO.StreamWriter file =
// new System.IO.StreamWriter(@"cadastro.txt", true))

  File.WriteAllText("cadastro.txt", "- Cadastro Paciente Particular\nNome: " +Nome + "\nEndereco: " +Endereco + "\nTelefone: "+Telefone + "\nData de nascimento: " +DataNascimento + "\nCPF: " + Cpf + "\nConvenio"+ Convenio);
}
}
  

      
