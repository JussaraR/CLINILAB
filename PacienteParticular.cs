using System;
using System.IO;

  class PacienteParticular: Pessoa{


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
  File.WriteAllText("cadastro.txt", "- Cadastro Paciente Particular\nNome: " +Nome + "\nEndereco: " +Endereco + "\nTelefone: "+Telefone + "\nData de nascimento: " +DataNascimento + "\nCPF: " + Cpf);
}
}
  

      
