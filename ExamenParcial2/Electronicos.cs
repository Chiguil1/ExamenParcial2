namespace ExamenParcial2
{
    public class Electronicos : Libros
    {
        public string Formato {  get; set; }
        public string Tamanio { get; set; }
        public Electronicos() 
        {
            Formato = string.Empty;
            Tamanio = string.Empty;
        }
    }
}
