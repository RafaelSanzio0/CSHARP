using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Models
{
    public class UserModel : BaseModel
    {
        private string _name;
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        private string _email;
        public string Email
        {
            get { return _email; }
            set { _email = value; }
        }
    }
}

/*
Quando trabalhamos com Model o principal foco é domínio do negócio. (BASICAMENTE TRABALHOS COM REGRA DE CAMPOS)
Além de validações mais específicas de um campo, podemos adicionar métodos de cálculos por exemplo do domínio que esteja fazendo.
Deixando especificamente para aquele model isto vai deixar a Model mais específica e Service com apenas regras de negócio.
Mas isso não é escrito em pedras, você pode criar arquitetura por exemplo sem a model e fazer tudo na service.

Mas quando você precisa garantir que o modelo precisa ser forte e precisa de ser tratado você pode Receber uma DTO e depois criar um Modelo com o Modelo criado e validado
você pode enviar para o banco de dados.
*/