using System;

namespace MiAplicacion
{
    class Program
    {
        static void Main(string[] args)
        {

int Asistencia, PParcial, Practica, ExFinal, suma, NotaFinal;
string linea;
 Console.WriteLine("-----------------------------------------------------------------");
 Console.WriteLine("--Bienvenido al Sistema de Registro de las Notas de los Alumnos--");
 Console.WriteLine("-----------------------------------------------------------------");
 Console.WriteLine("------Angel Rufino Alonzo Rojas       -       11-MISM-1-011------");
 Console.WriteLine("-----------------------------------------------------------------");
 Console.WriteLine("------Seccion 0908  -   C++ Programacion Orientada A Objeto------");
 Console.WriteLine("-----------------------------------------------------------------");
Console.WriteLine("");

 Console.Write("Ingrese la Nota de Asistencia: ");
 linea = Console.ReadLine();
 Asistencia = int.Parse(linea);
Console.WriteLine("");

 Console.Write("Ingrese la Nota Del Primer Parcial: ");
 linea = Console.ReadLine();
 PParcial = int.Parse(linea);
Console.WriteLine("");

 Console.Write("Ingrese la Nota de las Practicas: ");
 linea = Console.ReadLine();
 Practica = int.Parse(linea);
Console.WriteLine("");

 Console.Write("Ingrese Nota del Examen Final: ");
 linea = Console.ReadLine();
 ExFinal = int.Parse(linea);
 suma = Asistencia + PParcial + Practica + ExFinal;
 NotaFinal = suma;
Console.WriteLine("");

 Console.Write("La Nota Final Del Estudiante Es: ");
 Console.WriteLine(NotaFinal);
int promedio = (Asistencia + PParcial + Practica + ExFinal);
if (promedio >= 90)
{
 Console.Write("El Estudiante Aprobo con A");
 linea = Console.ReadLine();
}
else if (promedio >= 80){
    Console.Write("El Estudiante Aprobo con B");
    linea = Console.ReadLine();
    }
else if (promedio >= 75){
    Console.Write("El Estudiante Aprobo con C");
    linea = Console.ReadLine();
        }
else if (promedio >= 70){
    Console.Write("El Estudiante Aprobo con D");
    linea = Console.ReadLine();
}
else {
    Console.Write("El Estudiante Reprobo con F");
    linea = Console.ReadLine();
            }
 Console.ReadKey();
        }
    }
}
