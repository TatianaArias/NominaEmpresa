using System;
using static System.Console;
namespace NominaEmpresa
{
    public class Empresa
    {
        public double ObtenerSalarioPorEmpleado(int XCantidadOperarios)
        {
            double totalNomina = 0;
            double horasTrabajadas = 0;
            double valorPesos = 0;
            double totalHorasExtra = 0;
            double salariobruto = 0;
            double asigHorasExtra = 0;
            double acuSalarioBruto = 0;
            WriteLine("Valor de pesos por hora: ");
            valorPesos = Convert.ToInt32(ReadLine());
            for (int O = 1; O <= XCantidadOperarios; O++)
            {
                WriteLine("OPERARIO #  " + O);
                WriteLine("Cantidad de horas trabajadas");
                horasTrabajadas = Convert.ToInt32(ReadLine());
                salariobruto = horasTrabajadas * valorPesos;
                if (horasTrabajadas <= 40)
                {
                    WriteLine("No trabajó horas extras");
                    WriteLine("Su salario bruto es: " + salariobruto);
                    acuSalarioBruto = acuSalarioBruto + salariobruto;
                }
                else if (horasTrabajadas > 40)
                {
                    WriteLine("Trabajó Horas Extras");
                    double horasExtras = horasTrabajadas - 40;
                    WriteLine("Usted trabajó: " + horasExtras + " " + "horas extra.");
                    double valorHorasExtras = horasExtras * valorPesos * 1.5;
                    WriteLine("Su pago por las horas extras es: " + valorHorasExtras);
                    totalHorasExtra = valorHorasExtras + salariobruto;
                    WriteLine("El total de su salario incluyendo horas extras es: " + totalHorasExtra);
                    asigHorasExtra = asigHorasExtra + totalHorasExtra;
                }
            }
            totalNomina = totalNomina + asigHorasExtra + acuSalarioBruto;
            WriteLine("Total Nómina: ");
            return totalNomina;
        }
    }
}



