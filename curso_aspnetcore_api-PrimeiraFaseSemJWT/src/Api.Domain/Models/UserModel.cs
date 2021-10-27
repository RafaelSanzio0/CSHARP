using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Models
{
    public class UserModel
    {
        private Guid _id;
        public Guid Id
        {
            get { return _id; }
            set { _id = value; }
        }

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

        private DateTime _createAt;

        public DateTime CreateAt
        {
            get { return _createAt; }
            set { _createAt = value; }
        }

        private DateTime _updateAt;
        public DateTime UpdateAt
        {
            get { return _updateAt; }
            set { _updateAt = value; }
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