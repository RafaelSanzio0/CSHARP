using System;
namespace ByteBank.Sistemas
{
    public interface IAutenticavel // quem implementa essa interface deve obrigatoriamente inserir os metudos da classe
    {
        bool Autenticar(string senha);
        
    }
}
