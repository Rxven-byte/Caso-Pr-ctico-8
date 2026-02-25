namespace WebApplicationAPP.Models
{
    public class Servicio
    {
        public int Id { get; set; }
        public String Nombre { get; set; }
        public String Descripcion { get; set; }
        public decimal Monto { get; set;}
        public decimal IVA { get; set; }
        public string Area_de_servicio { get; set; }
        public string Encargo_del_servicio { get; set; }
        public string Sucursal { get; set; }
        public Boolean Estado { get; set; }
        public string Acciones { get; set; }
        public DateTime FechaDeRegistro { get; set; }
        public DateTime? FechaDeModificacion { get; set; }

    }
}
