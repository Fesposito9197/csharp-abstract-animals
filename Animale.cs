using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



public abstract class Animale
{
    string verso;
    protected string mangia;
    string dormi;

    protected Animale(string verso, string mangia)
    {
        this.verso = verso;
        this.mangia = mangia;
        
    }

    

    public void PrintVerso() => Console.WriteLine(verso);
    public abstract string GetMangia();
    public void PrintDormi() => Console.WriteLine("ZZZ");
}

