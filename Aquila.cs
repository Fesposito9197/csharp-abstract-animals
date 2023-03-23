using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



internal class Aquila : Animale
{
    public Aquila(string verso, string mangia) : base(verso, mangia) { }

    public override string GetMangia() => "(Cosa mangia l'aquila) " + mangia;
    

}

