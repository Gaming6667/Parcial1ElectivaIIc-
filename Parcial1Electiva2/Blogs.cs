using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial1Electiva2
{
    public class Blogs 
    {


        public int BlogID { get; set; }
        public string NameBlog { get; set; }
        public int CodigoUsuario { get; set; }


        public Blogs(int blogID, string nameBlog, int codigoUsuario)
        {
            this.BlogID = blogID;
            this.NameBlog = nameBlog;
            this.CodigoUsuario = codigoUsuario;
        }

        public Blogs()
        {

        }

        //

        //public Blogs(int BlogID, string NameBlog, int CodigoUsuario, )
        //{
        //    this.BlogID = BlogID;
        //    this.NameBlog = NameBlog;
        //    this.CodigoUsuario = CodigoUsuario;

        //}

    }
}
