using System;
using System.IO;
class MainClass {
  public static void Main (string[] args) {
    Console.WriteLine ("Bem vindo de volta, o que gostaria de fazer ?");
    Console.WriteLine("1. Cadastrar um paciente\n2. Marcar Uma Consulta\n3. Realizar uma cobrança");

    string opcao;
    string selecao;
    Pessoa p = new Pessoa ();
    //PacienteConvenio pc = new PacienteConvenio();
    PacienteParticular pp = new PacienteParticular();

    opcao = Console.ReadLine();

    if (opcao == "1")
    {
     pp.CadastrarParticular();
      /*Console.WriteLine(" O paciente possui convênio? ")
      if (selecao  == "sim")
      {
        pp.CadastrarParticular();
      
      }*/
    }


  }
}