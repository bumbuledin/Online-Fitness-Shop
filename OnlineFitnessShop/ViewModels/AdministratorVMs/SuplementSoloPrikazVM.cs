﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineFitnessShop.ViewModels.AdministratorVMs
{
    public class SuplementSoloPrikazVM
    {
        public int ProizvodID { get; set; }
        public string Naziv { get; set; }


        public float Cijena { get; set; }

        public string ImageUrl { get; set; }



        public int SuplementacijaID { get; set; }
        public string kategorijaSuplementacije { get; set; }


        public string Brend { get; set; }
        public float Tezina { get; set; }

        public int kolicina { get; set; }
    }
}
