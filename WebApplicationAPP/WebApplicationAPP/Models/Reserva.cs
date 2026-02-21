using Microsoft.AspNetCore.Http.HttpResults;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplicationAPP.Models
{
    [Table("Reserva")]
    public class Reserva
    {
        public int Id { get; set; }
        public string NombreDelAsociado { get; set; }
        public string Identificacion { get; set; }
        public string Telefono { get; set; }
        public string Correo { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public string Direccion { get; set; }
        public decimal MontoTotal { get; set; }
        public DateTime FechaDelServicio { get; set; }
        public DateTime FechaDeRegistro { get; set; }
        public int IdServicio { get; set; }
        // Relación
        public Servicio Servicio { get; set; }
    }
}

//CREATE TABLE RESERVAS (
//    NombreDelAsociado VARCHAR(150) NOT NULL,
//    Identificacion VARCHAR(30) NOT NULL,

//    Telefono VARCHAR(10) NOT NULL,
//    Correo VARCHAR(50) NOT NULL,
//    FechaNacimiento DATETIME NOT NULL,
//    Direccion VARCHAR(200) NOT NULL,
//    MontoTotal DECIMAL(18,2) NOT NULL,
//    FechaDelServicio DATETIME NOT NULL,
//    FechaDeRegistro DATETIME NOT NULL,
//    IdServicio INT NOT NULL,
//    PRIMARY KEY (Id),
//    CONSTRAINT FK_Reservas_Servicios 
//        FOREIGN KEY (IdServicio) REFERENCES SERVICIOS(Id)
//);