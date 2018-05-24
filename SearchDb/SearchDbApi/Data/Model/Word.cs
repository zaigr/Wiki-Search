﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace SearchDbApi.Data.Model
{
    public class Word
    {
        public int WordId { get; set; }
        [Column("Word")]
        public string Value { get; set; }
    }
}