using LiteDB;

namespace Modelos;

public class Cliente : Registro
{
    public string Nome {get; set;}
    [BsonId]
    public int Id {get; set;}
}