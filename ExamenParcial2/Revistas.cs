namespace ExamenParcial2
{
    public class Revistas : Libros
    {
        public string Volumen {  get; set; }
        public int Ejemplar { get; set; }
        public Revistas()
        {
            Volumen = string.Empty;
            Ejemplar = 0;
        }
    }
}
