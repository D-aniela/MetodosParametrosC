using System;

namespace RepartoSushi
{
    class Unidades
    {

        private int UnidadesDisponibles;
        private int UnidadesRealizandoEnvios;

        public Unidades()
        {
            UnidadesDisponibles = 10;
            UnidadesRealizandoEnvios = 0;
        }

        public Unidades(int UnidadesDip, int UnidadesEnv)
        {
            UnidadesDisponibles = UnidadesDip;
            UnidadesRealizandoEnvios = UnidadesEnv;
        }

        public void unidadesLlenas()
        {
            UnidadesDisponibles = UnidadesRealizandoEnvios;
            Console.WriteLine("Ya no hay unidades disponibles. Unidades Actuales:" + UnidadesDisponibles);
        }

        public void RealizarEnvio()
        {
            int envioRealizado;
            Console.WriteLine("Introduzca unidades que terminaron el envio");
            envioRealizado = int.Parse(Console.ReadLine());
            if (UnidadesDisponibles - envioRealizado < 0)
            {
                UnidadesDisponibles = 0;
                Console.WriteLine("No hay suficientes unidades");
            }
            else
            {
                UnidadesDisponibles = UnidadesDisponibles - envioRealizado;
                Console.WriteLine("La cantidad de unidades disponibles es: " + UnidadesDisponibles);
            }
        }

        public void EnvioCompletado()
        {
            int envioRealizado;
            Console.WriteLine("Introduzca unidades que terminaron el envio");
            envioRealizado = int.Parse(Console.ReadLine());
            if (UnidadesRealizandoEnvios - envioRealizado < 0)
            {
                UnidadesRealizandoEnvios = 0;
                Console.WriteLine("No hay unidades con envios");
            }
            else
            {
                UnidadesRealizandoEnvios = UnidadesRealizandoEnvios - envioRealizado;
                Console.WriteLine("La cantidad de unidades disponibles es: " + UnidadesRealizandoEnvios);
            }
        }

        public void ConsultarUnidades()
        {
            Console.WriteLine(UnidadesDisponibles);
        }

        public void mostrarOpciones()
        {
            Console.WriteLine("Elige una opción");
            Console.WriteLine("1. Realizar Envio");
            Console.WriteLine("2. Envio Completado");
            Console.WriteLine("3. Consultar Unidades");
        }
        class Program
        {
            static void Main(string[] args)
            {
                int unidadesMax, unidadesActual;
                int opcion, opcion1, opcion2, opcion3;
                bool change = true;

                Unidades objeto1 = new Unidades();
                //constructor
                Console.WriteLine("Introduce las unidades máximas: ");
                unidadesMax = int.Parse(Console.ReadLine());

                Unidades objeto2 = new Unidades();
                //constructor
                Console.WriteLine("Introduce las unidades actuales: ");
                unidadesActual = int.Parse(Console.ReadLine());

                Unidades objeto3 = new Unidades(unidadesActual, unidadesMax);
                Console.WriteLine("Unidades disponibles: " + (unidadesMax - unidadesActual));

                
                }

            }

        }

    }

