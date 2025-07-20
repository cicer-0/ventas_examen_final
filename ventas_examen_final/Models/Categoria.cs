namespace ventas_examen_final.Models
{
    public class Categoria
    {
        public int Id { get; set; }
        public string Nombre { get; set; }

        // Relación uno a muchos con Producto
        public ICollection<Producto> Productos { get; set; }
    }
}
