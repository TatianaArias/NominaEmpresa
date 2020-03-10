using System;
using static System.Console;

namespace NominaEmpresa
{
    class Program
    {
        static void Main(string[] args)
        {
            Empresa miEmpresa = new Empresa();
            int numero = 0;
            while (numero != 2)
            {
                WriteLine(System.Environment.NewLine);
                WriteLine("INDIQUE QUE CONSULTA DESEA REALIZAR: ");
                WriteLine(System.Environment.NewLine);
                WriteLine("1. Salario que le corresponde a cada empleado y  Total de la nómina.");
                WriteLine("2. Salir");
                WriteLine(System.Environment.NewLine);

                numero = Convert.ToInt32(ReadLine());
                switch (numero)
                {
                    case 1:
                        WriteLine("Ingrese la cantidad de Operarios: ");
                        int XCantidadOperarios = Convert.ToInt32(ReadLine());
                        double TotalSalario = miEmpresa.ObtenerSalarioPorEmpleado(XCantidadOperarios);
                        WriteLine(TotalSalario);
                        WriteLine(System.Environment.NewLine);

                        break;
                    case 2:
                        ReadKey();
                        break;
                }
            }
        }
    }
}

