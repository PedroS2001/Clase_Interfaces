namespace Entidades
{
    public class Leon : ICazador, ICarnivoro
    {
        int dientes;
        ConsoleColor color;

        public Leon(int dientes, ConsoleColor color)
        {
            this.dientes = dientes; 
            this.color = color; 
        }

        public string Comer(string comida)
        {
            return "Estoy comiendo " + comida;
        }

        public string Cazador()
        {
            return "Sali a cazar un ciervo";
        }
        string ICarnivoro.Cazador()
        {
            return "Estoy cazando como carnivoro";
        }

        public override string ToString()
        {
            return $"Dientes:  {this.dientes} - color : {this.color}";
        }


    }
}