using System;
using System.IO;
class MainClass {
  public static void Main (string[] args) {
    string opcao;
    string selecao;
    Pessoa p = new Pessoa ();
    PacienteConvenio pc = new PacienteConvenio();
    PacienteParticular pp = new PacienteParticular();

    Console.WriteLine ("Bem vindo de volta, o que gostaria de fazer ?");
    Console.WriteLine("1. Cadastrar um paciente\n2. Marcar Uma Consulta\n3. Realizar uma cobrança");
    opcao = Console.ReadLine();

    if (opcao == "1")
    {
      Console.WriteLine(" O paciente possui convênio? (Sim ou Não) ");
      opcao = Console.ReadLine();
        if (opcao  == "Sim") {
          pc.CadastrarConvenio();
         }
        if(opcao == "Não"){
          pp.CadastrarParticular();
        }

          

    }
    }


  }
