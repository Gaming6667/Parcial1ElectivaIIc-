using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial1Electiva2
{
    public class Users
    {
        public int id { get; set; }
        public string nombres { get; set; }
        public string apellidos { get; set; }



        public Users(int id, string nombres, string apellidos)
        {
            this.id = id;
            this.nombres = nombres;
            this.apellidos = apellidos;


        }
        //
        public Users()
        {
        }
    }

}
