using System;
using System.Text;
using Microsoft.Win32.SafeHandles;

namespace Library
{
    public class Patient 
    {
        private string PatientName;
        private string PatientId;
        private string PatientPhone;

//CONSTRUCTOOOOR
        public Patient(string nombre, string id, string phone) 
        {
            bool isValid = false;
            if ((!(string.IsNullOrEmpty(nombre))) && (!(string.IsNullOrEmpty(id))) && (!(string.IsNullOrEmpty(phone))))
            {
                isValid = true;
            }
            if (isValid == true)
            {
                this.PatientName = (nombre);
                this.PatientId = (phone);
                this.PatientId = (id);
            }
        }
    }
}



