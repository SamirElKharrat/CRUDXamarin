using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace CRUDXamarin.Models
{
    public class Alumno
    {
        [PrimaryKey,AutoIncrement]
        public int IdAlumno { get; set; }

        [MaxLength(50)]
        public string Nombre { get; set; }

        [MaxLength(50)]
        public string Apellido { get; set; }

        [MaxLength(50)]
        public string SegundoApellido { get; set; }
        public int Edad { get; set; }

        [MaxLength(100)]
        public string Email { get; set; }
    }
}
