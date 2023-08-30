using System;
using System.Data.Common;
using System.Text;

namespace Library
{
    public class Doctor
    {
        private string DoctorName;
        private string Specialty;




        public Doctor(string nombre, string especialidad) 
        {
            if (string.IsNullOrEmpty(nombre))
            {
                this.DoctorName = (nombre);
            }
            if (string.IsNullOrEmpty(especialidad))
            {
                this.Specialty = (especialidad);
            }
         }

        public string GetDocName()
        {
            return this.DoctorName;
        }

        public void SetDocName()
        {
        }
    }


}








