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
    }
}
