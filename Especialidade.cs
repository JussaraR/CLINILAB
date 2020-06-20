using System;
using System.IO;

class Especialidade {
  private string codigoEspecialidade;
  private string nomeEspecialidade;
  private double valorConsulta;
  string continuar = "s";
  double total; 

public string CodigoEspecialidade {
  get {
    return codigoEspecialidade;
  }
  set{ 
    codigoEspecialidade = value;
  }
}

public string NomeEspecialidade {
  get{
    return nomeEspecialidade;
  }
  set{
    nomeEspecialidade = value;
  }
}


public double ValorConsulta{
  get{
    return valorConsulta;
  }
  set{ 
    valorConsulta = value;
  }
}

  public void CalcularPreco(){
    string[] lines = File.ReadAllLines("precoEspecialidade.txt");
      foreach(var line in lines) Console.WriteLine(line);
    Console.WriteLine();
    Console.WriteLine("- Informe o código da especialidade: ");
    CodigoEspecialidade = Console.ReadLine();
    if(CodigoEspecialidade == "1"){
      total = 200;
      Console.WriteLine(" O valor da dos procedimentos é de:"+total);
  }





}









}