﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ayakkabi_Firmasi
{
    public class Mudur : Kisi
    {
        public int AylikSatis { get; set; }

        public override void MaasHesapla()
        {
            base.MaasHesapla();
            maas += AylikSatis*11/10;
        }
    }
}
