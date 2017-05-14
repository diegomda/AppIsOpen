using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IsOpen.Models
{
    public class Negocio
    {
        public int NegocioId { get; set; }
        public string Name { get; set; }
        public string Direccion { get; set; }
        public string Logo { get; set; }
        public string Email { get; set; }
        public string Telefono { get; set; }
        public string Descripcion { get; set; }
        public int UserId { get; set; }
        public bool IsActive { get; set; }
        public int Order { get; set; }
        public string FullLogo
        {
            get
            {
                if (string.IsNullOrEmpty(Logo))
                {
                    return "avatar_shield.png";
                }

                return string.Format("http://isopenbackend.azurewebsites.net{0}", Logo.Substring(1));
            }
        }
    }
}
