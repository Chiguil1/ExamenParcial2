namespace ExamenParcial2
{
    public class Libros
    {
        public string Titulo {  get; set; }
        public string Autor { get; set; }
        public string Genero { get; set; }
        public int Publicacion {  get; set; }

        public Libros()
        {
            Titulo = String.Empty;
            Autor = String.Empty;
            Genero = String.Empty;
            Publicacion = 0;
        }
    }
}
