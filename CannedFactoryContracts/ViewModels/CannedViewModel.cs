﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace CannedFactoryContracts.ViewModels
{
    //Изготовляемое изделие
    public class CannedViewModel
    {
        public int Id { get; set; }

        [DisplayName("Название изделия")]
        public string CannedName { get; set; }

        [DisplayName("Цена")]
        public decimal Price { get; set; }

        public Dictionary<int, (string, int)> CannedComponents { get; set; }
    }
}
