﻿using System;
using ByteBank.Funcionarios;

namespace ByteBank.Sistemas
{
    public class SistemaInterno
    {
        public SistemaInterno()
        {
        }

        public bool Logar(IAutenticavel usuario, string senha)
        {
            bool usuarioAutenticado = usuario.Autenticar(senha);

            if (usuarioAutenticado)
            {
                Console.WriteLine("Bem-vindo ao sistema!!!");
                return true;
            }
            else
            {
                Console.WriteLine("Senha incorreta");
                return false;
            }
        }
    }
}
