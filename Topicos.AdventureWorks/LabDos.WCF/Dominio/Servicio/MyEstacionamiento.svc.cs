//------------------------------------------------------------------------------
// <copyright file="WebDataService.svc.cs" company="Microsoft">
//     Copyright (c) Microsoft Corporation.  All rights reserved.
// </copyright>
//------------------------------------------------------------------------------
using LabDos.Model;
using System;
using System.Collections.Generic;
using System.Data.Services;
using System.Data.Services.Common;
using System.Data.Services.Providers;
using System.Linq;
using System.ServiceModel.Web;
using System.Web;

namespace LabDos.WCF.Dominio.Servicio
{
    public class MyEstacionamiento : EntityFrameworkDataService<ExamenAnalisisEntities>
    {
        // This method is called only once to initialize service-wide policies.
        public static void InitializeService(DataServiceConfiguration config)
        {
            // TODO: set rules to indicate which entity sets and service operations are visible, updatable, etc.
            // Examples:
            // config.SetEntitySetAccessRule("MyEntityset", EntitySetRights.AllRead);
            // config.SetServiceOperationAccessRule("MyServiceOperation", ServiceOperationRights.All);
            config.DataServiceBehavior.MaxProtocolVersion = DataServiceProtocolVersion.V3;
        }
        public IList<Estacionamiento> ListarEstacionamientoPorFecha(string FechaInicial, string FechaSalida)
        {
            var laEspecificacion = new LabDos.WCF.Dominio.Especificacion.Estacionamiento();
            var elResultado = laEspecificacion.ListarEstacionamientoPorFecha(FechaInicial, FechaSalida);
            return elResultado;
        }
        public IList<Estacionamiento> ListarEstacionamientosPorProvincia(string provincia)
        {
            var laEspecificacion = new LabDos.WCF.Dominio.Especificacion.Estacionamiento();
            var elResultado = laEspecificacion.ListarEstacionamientoPorProvincia(provincia);
            return elResultado;
        }
        public string GetData(int value)
        {
            return string.Format("You entered: {0}", value);
        }

        public CompositeType GetDataUsingDataContract(CompositeType composite)
        {
            if (composite == null)
            {
                throw new ArgumentNullException("composite");
            }
            if (composite.BoolValue)
            {
                composite.StringValue += "Suffix";
            }
            return composite;
        }





    }
}
