namespace JavierCifuentes.Model
{
    public class Avion : Vehiculo
    {
        private float alturaMaxima;
        public float AlturaMaxima
        {
            get { return alturaMaxima; }
            set { alturaMaxima = value; }
        }

        private float alturaMinima;
        public float AlturaMinima
        {
            get { return alturaMinima; }
            set { alturaMinima = value; }
        }

        public void Despegar()
        {

        }

        public void Aterrizar()
        {

        }

        public void DisminuirAltura(float pie)
        {

        }

        public Avion() { }
        public Avion(string marca, string modelo, float velocidadMinima, float velocidadMaxima) => (Marca, Modelo, VelocidadMinima, VelocidadMaxima) = (marca, modelo, velocidadMinima, velocidadMaxima);

        public override string ToString()
        {
            return $"Marca: {this.marca} - Modelo: {this.modelo} - Velocidad Minima: {this.velocidadMinima} - Velocidad Maxima: {this.velocidadMaxima}";
        }
    }
}