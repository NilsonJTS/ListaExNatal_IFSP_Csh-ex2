/*

*/

using System.ComponentModel.DataAnnotations;

namespace ex2;

public class CalcSimples
{

    public double A=0;
    public double B=0;
    public double C=0;
    
    public CalcSimples()
    {
    }

    public void LeituraDados(){
        
        Console.WriteLine("Coloque o valor de A: ");
        A=Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Coloque o valor de B ");
        B=Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Coloque o valor de C: ");
        C=Convert.ToDouble(Console.ReadLine());

        Console.Write(Calcular());
    }

    public double Calcular(){

        double S= Math.Pow( this.B + this.C , 2);
        double R= Math.Pow( this.A + this.B , 2);
        double D= (R+S)/2;

        return D;
    }

}
