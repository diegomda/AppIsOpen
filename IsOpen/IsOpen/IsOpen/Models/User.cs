using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IsOpen.Models
{
    public class User
    {
        public int UserId { get; set; }
        public string Name { get; set; }
        public string Direccion { get; set; }
        public string Email { get; set; }
        public string Logo { get; set; }
        public List<Negocio> Negocio { get; set; }
        public string FullName { get { return string.Format("{0}", Name); } }

        public string FullPicture
        {
            get
            {
                if (string.IsNullOrEmpty(Logo))
                {
                    return "avatar_user.png";
                }

                return string.Format("http://isopenbackend.azurewebsites.net{0}", Logo.Substring(1));
            }
        }
    }
}
