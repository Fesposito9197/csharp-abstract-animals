﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



internal class Passerotto : Animale , IVolante
{
    public Passerotto(string verso, string mangia) : base(verso, mangia) { }

    public override string GetMangia() => "(Cosa mangia il passerotto) " + mangia;

    public void Vola()
    {
        Console.WriteLine("Sto volando!!!");
    }
}

