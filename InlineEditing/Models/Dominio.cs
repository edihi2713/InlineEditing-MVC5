using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace InlineEditing.Models
{
    public class Dominio
    {
        public int domDominioId { get; set; }
        public string domDescripcion { get; set; }
        public string domObservacion { get; set; }
        public bool domAnulado { get; set; }
        public Nullable<System.DateTime> domFechaCreacion { get; set; }
        public Nullable<int> empEmpleadoIdCreador { get; set; }
        public System.DateTime domFechaDesde { get; set; }
        public Nullable<System.DateTime> domFechaHasta { get; set; }
    }
}