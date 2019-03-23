namespace JavierCifuentes.Model
{
    public abstract class Vehiculo
    {
        public string marca;
        public string Marca
        {
            get { return marca; }
            set { marca = value; }
        }

        public string modelo;
        public string Modelo
        {
            get { return modelo; }
            set { modelo = value; }
        }
        public float velocidadMaxima;
        public float VelocidadMaxima
        {
            get { return velocidadMaxima; }
            set { velocidadMaxima = value; }
        }

        public float velocidadMinima;
        public float VelocidadMinima
        {
            get { return velocidadMinima; }
            set { velocidadMinima = value; }
        }
        public void encender()
        {

        }

        public void apagar()
        {

        }

        public Vehiculo() { }
        public Vehiculo(string marca, string modelo, float velocidadMinima, float velocidadMaxima) => (Marca, Modelo, VelocidadMinima, VelocidadMaxima) = (marca, modelo, velocidadMinima, velocidadMaxima); 
    }
}