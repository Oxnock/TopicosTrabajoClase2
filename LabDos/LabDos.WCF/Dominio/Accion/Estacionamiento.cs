using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using LabDos.Model;

namespace LabDos.WCF.Dominio.Accion
{
    public class Estacionamiento
    {
        public IList<Estacionamiento> ListarEstacionamientoPorFecha(string fechaInicial, string fechaFinal)
        {
            var elRepositorio = new Repositorio.Estacionamiento();
            var elResultado = elRepositorio.ListarEstacionamientoPorFecha(fechaInicial,fechaFinal);
            return elResultado;
        }
        public IList<Estacionamiento> ListarEstacionamientoPorProvincia(string provincia)
        {
            var elRepositorio = new Repositorio.Estacionamiento();
            var elResultado = elRepositorio.ListarEstacionamientoPorProvincia(provincia);
            return elResultado;
        }
    }
}