namespace ventas_examen_final.Models
{
    public class Usuario
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Correo { get; set; }
        public string Contrasena { get; set; }
        public DateTime FechaRegistro { get; set; }

        // Relación uno a muchos con Venta
        public ICollection<Venta> Ventas { get; set; }
    }
}
