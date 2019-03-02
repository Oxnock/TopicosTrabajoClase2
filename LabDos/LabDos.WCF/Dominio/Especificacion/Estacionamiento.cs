using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using LabDos.Model;

namespace LabDos.WCF.Dominio.Especificacion
{
    public class Estacionamiento
    {
        public IList<Estacionamiento> ListarEstacionamientoPorFecha(string fechaInicial, string fechaFinal)
        {
            var laAccion = new Accion.Estacionamiento();
            var elResultado = laAccion.ListarEstacionamientoPorFecha(fechaInicial,fechaFinal);
            return elResultado;
        }
        public IList<Estacionamiento> ListarEstacionamientoPorProvincia(string provincia)
        {
            var laAccion = new Accion.Estacionamiento();
            var elResultado = laAccion.ListarEstacionamientoPorProvincia(provincia);
            return elResultado;
        }
    }
}