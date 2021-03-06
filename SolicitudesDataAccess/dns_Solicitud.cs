//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SolicitudesDataAccess
{
    using System;
    using System.Collections.Generic;
    
    public partial class dns_Solicitud
    {
        public int Id { get; set; }
        public int IdLote { get; set; }
        public string NroPeriodo { get; set; }
        public string NroSolicitud { get; set; }
        public string NombreSolicitud { get; set; }
        public System.DateTime FechaSolicitud { get; set; }
        public Nullable<System.DateTime> FechaVencimiento { get; set; }
        public Nullable<System.DateTime> FechaEnviado { get; set; }
        public Nullable<System.DateTime> OC_Fecha { get; set; }
        public string OC_Nro { get; set; }
        public string Solicito { get; set; }
        public string Ubicacion { get; set; }
        public string Observacion { get; set; }
        public Nullable<double> imp_Total { get; set; }
        public Nullable<double> imp_Facturado { get; set; }
        public Nullable<double> imp_Saldo { get; set; }
        public Nullable<System.DateTime> FechaVisitaObra { get; set; }
        public Nullable<int> IdTipoCertificacion { get; set; }
        public Nullable<int> IdEstadoTrabajo { get; set; }
        public Nullable<int> IdEstadoFacturacion { get; set; }
        public string IdFactura { get; set; }
        public Nullable<System.DateTime> Creado { get; set; }
        public string CreadoPor { get; set; }
        public Nullable<System.DateTime> Modificado { get; set; }
        public string ModificadoPor { get; set; }
        public string AsignadoA { get; set; }
        public string InformeEstado { get; set; }
        public Nullable<int> IdEstadoSolicitud { get; set; }
        public Nullable<int> IdGestionComercial { get; set; }
        public Nullable<bool> AlarmRecurrent { get; set; }
        public Nullable<System.DateTime> MovimientosFechaDesde { get; set; }
        public Nullable<System.DateTime> MovimientosFechaHasta { get; set; }
    }
}
