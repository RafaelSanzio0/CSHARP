﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.DTO.Municipio
{
    public class MunicipioDTOUpdateResult
    {
        public Guid Id { get; set; }

        public string Nome { get; set; }

        public int CodIBGE { get; set; }

        public Guid UfId { get; set; }

        public DateTime UpdateAt { get; set; }

    }
}
