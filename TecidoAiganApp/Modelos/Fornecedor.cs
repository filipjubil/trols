using LiteDB;

namespace Modelos;

public class Fornecedor : Registro
{   
  [BsonID]
  public int Id { get; set; }
  
  public string Email { get; set; }
    
    string passaword;
    string cpf;
}











