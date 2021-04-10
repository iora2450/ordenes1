using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ordenes
{
    public static class Utiles
    {
        public static int userid { get; set; }
        public static models.USUARIOS guse { get; set; }
    }
    public class util
    {
        int id1;
       public util(int id)
        {
            id1 = id;

        }
        public models.USUARIOS getu()
         {
            models.USUARIOS u = new models.USUARIOS();
            try
            {
                using (ordenes.models.ordenesEntities db = new models.ordenesEntities())
                {
                    var lst = from d in db.USUARIOS
                              where d.ID == id1 
                              select d;

                    u = lst.First();    
                }

                



                    return u;
            }
            catch (Exception e)
            {

                return u;
            }
        }

     }
}

