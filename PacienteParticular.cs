using System;
using System.IO;

  class PacienteParticular: Pessoa{
    protected string convenio;

    public string Conveniio{
      get{
        return convenio;
      }
      set{
        convenio = value;
      }
    }


  public void CadastrarParticular(){
    
  Console.WriteLine("- Cadastro paciente particular");
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
 
  //using (System.IO.StreamWriter file =
   // new System.IO.StreamWriter(@"cadastro.txt", true))

  File.WriteAllText("cadastro.txt", "- Cadastro Paciente Particular\nNome: " +Nome + "\nEndereco: " +Endereco + "\nTelefone: "+Telefone + "\nData de nascimento: " +DataNascimento + "\nCPF: " + Cpf);
}
}
  

      
