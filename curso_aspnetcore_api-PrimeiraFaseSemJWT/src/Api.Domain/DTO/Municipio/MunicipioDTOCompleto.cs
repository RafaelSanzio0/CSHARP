﻿using Domain.DTO.Uf;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.DTO.Municipio
{
    public class MunicipioDTOCompleto
    {
        public Guid Id { get; set; }

        public string Nome { get; set; }

        public int CodIBGE { get; set; }

        public Guid UfId { get; set; }

        public UfDTO Uf { get; set; }
    }
}

// aqui é quando quero fazer um retorno mais detalhado
