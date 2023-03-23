﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



internal class Delfino : Animale , INuotante
{
    public Delfino(string verso, string mangia) : base(verso, mangia) { }

    public override string GetMangia() => "(Cosa mangia il delfino) " + mangia;
    public void Nuota()
    {
        Console.WriteLine("Sto nuotando!!!");
    }
}

