﻿using SIARH.Aplication.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIARH.Aplication.DTOs
{
    public class RefAmbitoUpdateDTO : RefAmbitoCreateDTO
    {
        public int IdAmbito { get; set; }

    }
}
