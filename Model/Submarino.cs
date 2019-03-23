namespace JavierCifuentes.Model
{
    public class Submarino : Vehiculo
    {
        private float profundidadMaxima;
        public float ProfundidadMaxima
        {
            get { return profundidadMaxima; }
            set { profundidadMaxima = value; }
        }

        public void Sumergir(float metros)
        {

        }
        public Submarino() { }
        public Submarino(string marca, string modelo, float profundidadMaxima) => (Marca, Modelo, ProfundidadMaxima) = (marca, modelo, profundidadMaxima);

        public override string ToString()
        {
            return $"Marca: {this.marca} - Modelo: {this.modelo} - Profundidad maxima: {this.profundidadMaxima}";
        }
    }
}