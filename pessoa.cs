using System;
using System.IO;

class pessoa {
protected string nome;
protected string dataNascimento;
protected string telefone;
protected string email;
protected double cpf;

public string Nome{
  get {
  return nome;
  }
  set {
    nome = value;
  }

} 

public string DataNascimento{
get {
    return dataNascimento;
  }
  set {
    nome = value; 
  }
}
  

public string Telefone {
  get {
    return telefone;
    }
  set {
    nome = value ;
    }
}

public string Email {
  get{
    return email;
  }
  set {
    email = value;
  }
}

public double Cpf {
  get{ 
    return cpf;
  }
  set {
    cpf = value; 
  }
}
















