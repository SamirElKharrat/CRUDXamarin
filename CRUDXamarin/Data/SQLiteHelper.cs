using System;
using System.Collections.Generic;
using System.Text;
using SQLite;
using CRUDXamarin.Models;
using System.Threading.Tasks;

namespace CRUDXamarin.Data
{
    public class SQLiteHelper
    {
        SQLiteAsyncConnection con;

        public SQLiteHelper(string db)
        {
            con = new SQLiteAsyncConnection(db);
            con.CreateTableAsync<Alumno>().Wait();
        }

        public Task <int> GuardarAlumnoAsync(Alumno alum)
        {
            if (alum.IdAlumno == 0)
            {
                return con.InsertAsync(alum);
            }
            else
            {
                return null;
            }
        }

        public Task<List<Alumno>> MostrarAlumnosAsync()
        {
            return con.Table<Alumno>().ToListAsync();
        }

        public Task<Alumno> MostarAlumnoPorId(int idAlumno)
        {
            return con.Table<Alumno>().Where(a => a.IdAlumno == idAlumno).FirstOrDefaultAsync(); 
        }
    }
}
