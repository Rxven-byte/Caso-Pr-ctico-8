using Microsoft.AspNetCore.Http.HttpResults;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplicationAPP.Models
{
    
    public class PersonaViewModel
    {
        public int Id { get; set; }

        public string Nombre { get; set; }

        public string Apellido { get; set; }

        public bool Estado { get; set; }
    }
}
