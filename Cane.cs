using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


internal class Cane : Animale , INuotante
{
    public Cane(string verso, string mangia) : base(verso, mangia) { }

    public override string GetMangia() => "(Cosa mangia il cane) " + mangia;

    public void Nuota()
    {
        Console.WriteLine("Sto nuotando!!!");
    }
}

