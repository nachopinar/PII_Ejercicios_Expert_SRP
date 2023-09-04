using System;
using System.Data.Common;
using System.Text;

namespace Library
{
    public class Doctor
    {
        private string DoctorName;
        private string Specialty;

//CONSTRUCTOR
        public Doctor(string nombre, string especialidad) 
        {
            bool isValid = false;
            if ((!(string.IsNullOrEmpty(nombre))) && (!(string.IsNullOrEmpty(especialidad))))
            {
                isValid = true;
            }
            if (isValid == true) 
            {
                this.DoctorName = (nombre);
                this.Specialty = especialidad;
            }
        }
    }
}

//podria hacer algun isValid aparte y no dentro del constructor;

