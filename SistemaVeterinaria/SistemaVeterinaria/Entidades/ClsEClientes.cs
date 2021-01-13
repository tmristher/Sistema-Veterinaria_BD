﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaVeterinaria.Entidades
{
    class ClsEClientes
    {
        public string Dni { get; private  set; }
        public string Nombre { get; private set; }
        public string Apellido { get; private set; }
        public string Telefono { get; private set; }
        public string Email { get; private set; }
        public string Direccion { get; private set; }

        public Principal.FrmClientes FrmClientes
        {
            get => default(Principal.FrmClientes);
            set
            {
            }
        }

        internal Negocios.ClsNClientes ClsNClientes
        {
            get => default(Negocios.ClsNClientes);
            set
            {
            }
        }


        public static ClsEClientes Save(string _dni, string _nombre, string _apellido, string _telefono, string _email, string _direccion)
        {
            return new ClsEClientes()
            {
                Dni = _dni,
                Nombre = _nombre,
                Apellido = _apellido,
                Telefono = _telefono,
                Email = _email,
                Direccion = _direccion
            };
        }
       
        /*public void Update(string _nombre,string _direccion,string _telefono,string _fecha,string _hora,string _actividad)
        {
            Nombres = _nombre;
            Direccion = _direccion;
            Telefono = _telefono;
            Fecha = _fecha;
            Hora = _hora;
            Actividad = _actividad;
        }*/

        public void  Update(string _nombre, string _apellido, string _telefono, string _email, string _direccion)
        {
            Nombre = _nombre;
            Apellido = _apellido;
            Telefono = _telefono;
            Email = _email;
            Direccion = _direccion;

           
        }

        public void Search(string dni)
        {

        }
        public void Delete(string dni)
        {

        }



    }
}
