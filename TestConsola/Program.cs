using Entidades;

namespace TestConsola
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello, World!");

            //Persona p = new Persona("Juan", 12);
            Leon l = new Leon(20, ConsoleColor.Green);

            //Arana<Persona> a = new Arana<Persona>();
            //Arana<Leon> aranaLeon = new Arana<Leon>();

            //Console.WriteLine( p.Cazador() );
            //Console.WriteLine( l.Cazador() );
            //Console.WriteLine( ((ICarnivoro) l ).Cazador()  );

            //Console.WriteLine( a.Metodo( p ) );
            //Console.WriteLine( aranaLeon.Metodo( l ) );
            //Console.WriteLine( a.Cazador() );

            //Console.WriteLine( l.Comer("Hamburguesa con queso") );



            Guardar<Leon> guardar = new Guardar<Leon>();


            IIGuardar<Leon> guardarLeon = (IIGuardar<Leon>) guardar ;
            guardarLeon.Guardar(l) ;
            //Equivalente ->
            ((IIGuardar<Leon>)guardar).Guardar(l);


        }
    }
}