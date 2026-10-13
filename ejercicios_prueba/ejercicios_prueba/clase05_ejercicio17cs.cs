using System;
using System.Collections.Generic;
using System.Text;

namespace ejercicios_prueba
{
    public class clase05_ejercicio17cs
    {


        static long pasos = 0;   // contador de operaciones

        // Cuenta UNA comparación y devuelve su resultado (true / false)
        static bool Cond(bool resultado)
        {
            pasos++;
            return resultado;
        }

        // ===== MÉTODO QUE ANALIZAMOS (cada operación suma 1 a pasos) =====
        static int SobreElPromedio(int[] notas)
        {
            double suma = 0; pasos++;
            for (int i = 0; Cond(i < notas.Length); i++)
            { suma += notas[i]; pasos++; }
            double prom = suma / notas.Length; pasos++;
            int mayores = 0; pasos++;
            for (int i = 0; Cond(i < notas.Length); i++)
                if (Cond(notas[i] >= prom))
                { mayores++; pasos++; }
            pasos++; return mayores;
        }

        // ===== TU RESPUESTA: escribe aquí tu T(n) en C#, por ejemplo: return 2 * n + 3; =====
        static long MiFormula(long n)
        {
            return 5*n + 6; 
        }

        static void Main(string[] args)
        {
            Console.WriteLine("    n | pasos | tu T(n) | ¿coincide?");
            foreach (int n in new[] { 1, 2, 3, 10 })
            {
                int[] notas = new int[n];
                for (int i = 0; i < n; i++) notas[i] = 70;   // todas iguales: todas llegan al promedio
                pasos = 0;
                SobreElPromedio(notas);
                long tuyo = MiFormula(n);
                string ok = tuyo == pasos ? "sí" : "NO";
                Console.WriteLine($"{n,5} | {pasos,5} | {tuyo,7} | {ok}");
            }
        }
    }
}    


