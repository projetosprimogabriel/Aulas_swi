namespace aula;
class Exemplo
{
  //atributos

public string nome="";

public int idade = 0;

public bool vacinado = false;

  //métodos  

  public void mostramsg(){
    Console.WriteLine("Oi 2°F");
  }

  public void mostranome(string texto){
    Console.WriteLine("Oi" +texto);
  }

  public string msg(){
     return "Olá, tudo bem?";
  }

  public int somar(int a, int b){
    return a+b; 
  }
}
