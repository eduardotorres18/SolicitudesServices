using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using SolicitudesDataAccess;

namespace SolicitudesServices.Controllers
{
    public class SolicitudController : ApiController
    {
        // GET api/Solicitud
        public IEnumerable<dns_Solicitud> Get() 
        {
            using (aDbDEINOSCloud_DevEntities entities = new aDbDEINOSCloud_DevEntities()) {
                return entities.dns_Solicitud.ToList();
            }
        }

        // GET api/solicitud/5
        public dns_Solicitud Get(int id) {
            using (aDbDEINOSCloud_DevEntities entities = new aDbDEINOSCloud_DevEntities()) {
                return entities.dns_Solicitud.FirstOrDefault(e => e.Id == id);
            }
        
        }


    }
}
