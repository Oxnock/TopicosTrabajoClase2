using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using LabDos.Model;

namespace LabDos.WCF.Dominio.Repositorio
{
    internal class Estacionamiento
    {
        private static ExamenAnalisisEntities _contexto = new ExamenAnalisisEntities();
        public Estacionamiento()
        {
            _contexto.Configuration.ProxyCreationEnabled = false;
            _contexto.Configuration.LazyLoadingEnabled = true;
        }

        public Estacionamiento(bool lazyLoadingEnabled)
        {
            _contexto.Configuration.ProxyCreationEnabled = false;
            _contexto.Configuration.LazyLoadingEnabled = lazyLoadingEnabled;
        }
        internal IList<Estacionamiento> ListarEstacionamientoPorFecha(string fechaInicial, string fechaFinal)
        {
            IList<Estacionamiento> elResultado = new List<Estacionamiento>();
            elResultado = _contexto.Estacionamientoes.Where(
                p => fechaFinal <= p.FechaHoraSalida && p.FechaHoraIngresp <= fechaInicial).OrderByDescending(o => o.Name).ToList();
            var elNuevoResultado = CompletarPropiedadesDeNavegacion(elResultado);
            return elNuevoResultado;
        }
        internal IList<Estacionamiento> ListarEstacionamientoPorProvincia(string provincia)
        {
            IList<Estacionamiento> elResultado = new List<Estacionamiento>();
            elResultado = _contexto.Estacionamientoes.Where(
                p => provincia <= p.ListPrice && p.ListPrice <= precioSuperior).OrderByDescending(o => o.Name).ToList();
            var elNuevoResultado = CompletarPropiedadesDeNavegacion(elResultado);
            return elNuevoResultado;
        }




    }
}