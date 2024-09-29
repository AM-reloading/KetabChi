using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;
using DataAccess;

namespace BusinessLogic
{
    public class BLbook
    {
        DAbook DA = new DAbook();


        public void MchangeAGO(int now, int aid)
        {
            DA.MchangeAGO(now, aid);
        }
        public void TchangeAGO(int now, int aid)
        {
            DA.TchangeAGO(now, aid);
        }


        public void create (Book c)
        {
            DA.create(c);
        }
        public void delete(int id, deleted d)
        {
            DA.delete(id, d);
        }
        public void updata(int id, Book u, updataed uhistory)
        {
            DA.updata(id, u, uhistory);
        }



        public void mcreate (moshtarekin c )
        {
            DA.mcreate(c /*, bc*/);
        }
        public void mupdata(int id, moshtarekin u, updataed uhistory )
        {
            DA.mupdata(id, u, uhistory/*, bookname*/);
        }
        public void mdelete(int id, deleted d)
        {
            DA.mdelete(id, d);
        }



        public void tcreate(trust c)
        {
            DA.tcreate(c);
        }
        public void tupdata(int id, string bo, string mo, string nm, string nb, trust u)
        {
            DA.tupdata(id, bo, mo, nm, nb, u);
        }
        public void tdelete(int id)
        {
            DA.tdelete(id);
        }



        public void acreate(admin c)
        {
            DA.acreate(c);
        }
        public void aupdata(int id, admin u, updataed uhistory)
        {
            DA.aupdata(id, u, uhistory);
        }
        public void adelete(int id, deleted d)
        {
            DA.adelete(id, d);
        }
        public void atem(int temid, string newtem)
        {
            DA.atem(temid, newtem);
        }




        public void Backup(string filename)
        {
            DA.Backup(filename);
        }
        public void Restore(string filename)
        {
            DA.Restore(filename);
        }
        public void DeleteDatabase()
        {
            DA.DeleteDatabase();
        }
    }
}
