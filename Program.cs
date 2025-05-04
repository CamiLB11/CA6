using System;

namespace AlgoritmosBusqueda
{
     public static class Busquedas
    {
        static void Main(string[] args)
        {
            // Crear un arreglo de ejemplo
            int[] arreglo = { 4, 8, 15, 16, 23, 42, 50, 65, 78, 90 };
            
            // Mostrar el arreglo
            Console.WriteLine("Arreglo original:");
            MostrarArreglo(arreglo);
            
            // Probar búsqueda lineal
            Console.WriteLine("\n=== BÚSQUEDA LINEAL ===");
            int elementoBuscar = 23;
            int posicionLineal = BusquedaLineal(arreglo, elementoBuscar);
            MostrarResultado(posicionLineal, elementoBuscar);
            
            // Probar un elemento que no existe
            elementoBuscar = 100;
            posicionLineal = BusquedaLineal(arreglo, elementoBuscar);
            MostrarResultado(posicionLineal, elementoBuscar);
            
            // Probar búsqueda binaria
            Console.WriteLine("\n=== BÚSQUEDA BINARIA ===");
            elementoBuscar = 42;
            int posicionBinaria = BusquedaBinaria(arreglo, elementoBuscar);
            MostrarResultado(posicionBinaria, elementoBuscar);
            
            // Probar un elemento que no existe
            elementoBuscar = 30;
            posicionBinaria = BusquedaBinaria(arreglo, elementoBuscar);
            MostrarResultado(posicionBinaria, elementoBuscar);
            
            
            
        }
        
        
        public static int BusquedaLineal(int[] arreglo, int elemento)
        {
            
            // Recorrer el arreglo elemento por elemento
            for (int i = 0; i < arreglo.Length; i++)
            {
                
                // Si el elemento actual es igual al buscado, retornar su posición
                if (arreglo[i] == elemento)
                {
                    return i;
                }
            }
            
            // Si no se encuentra el elemento, retornar -1
            return -1;
        }
        
        
        public static int BusquedaBinaria(int[] arreglo, int elemento)
        {
            int izquierda = 0;
            int derecha = arreglo.Length - 1;
            
            // Mientras el rango de búsqueda sea válido
            while (izquierda <= derecha)
            {
                // Calcular el punto medio
                int medio = izquierda + (derecha - izquierda) / 2;
                
                // Si el elemento está en el medio, retornar su posición
                if (arreglo[medio] == elemento)
                {
                    return medio;
                }
                
                // Si el elemento es mayor que el del medio, buscar en la mitad derecha
                if (arreglo[medio] < elemento)
                {
                    izquierda = medio + 1;
                }
                // Si el elemento es menor que el del medio, buscar en la mitad izquierda
                else
                {
                    derecha = medio - 1;
                }
            }
            
            // Si no se encuentra el elemento, retornar -1
            return -1;
        }
        
        
        public static void MostrarArreglo(int[] arreglo)
        {
            Console.Write("[ ");
            for (int i = 0; i < arreglo.Length; i++)
            {
                Console.Write(arreglo[i]);
                if (i < arreglo.Length - 1)
                {
                    Console.Write(", ");
                }
            }
            Console.WriteLine(" ]");
        }
        
      
        public static void MostrarResultado(int posicion, int elemento)
        {
            if (posicion != -1)
            {
                Console.WriteLine($"El elemento {elemento} se encontró en la posición {posicion}");
            }
            else
            {
                Console.WriteLine($"El elemento {elemento} no se encontró en el arreglo");
            }
        }
        
        
    }
}