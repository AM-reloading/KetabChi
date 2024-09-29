using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;
using System.Data.Entity;
using Microsoft.SqlServer.Management.Common;
using Microsoft.SqlServer.Management.Smo;
using Microsoft.Data.SqlClient;

namespace DataAccess
{
    public class DAbook
    {
        KetabkhoneEntities a = new KetabkhoneEntities();

        public void MchangeAGO(int now , int aid)
        {
            
            var q = a.moshtarekins.Where(i=> i.moshtarekin_id == aid);
            if (q.Count() == 1)
            {
                moshtarekin p = new moshtarekin();
                p = q.Single();
                p.moshtarekin_timeago = now;
                a.SaveChanges();
            }
        }
        public void TchangeAGO(int now, int aid)
        {

            var q = a.trusts.Where(i => i.trust_id == aid);
            if (q.Count() == 1)
            {
                trust p = new trust();
                p = q.Single();
                p.trust_later = now;
                a.SaveChanges();
            }
        }



        public void create (Book c)
        {
            a.Books.Add(c);
            a.SaveChanges();
        }
        public void delete (int id , deleted d)
        {
            var q = a.Books.Where(i => i.book_id == id);
            if (q.Count()==1)
            {
                a.deleteds.Add(d);
                var e = a.trusts.Where(i => i.trust_book_id == id);
                if (e.Count() == 1)
                {
                    a.trusts.Remove(e.Single());
                    //a.SaveChanges();
                }
                var E = a.moshtarekins.Where(i => i.moshtarekin_b_id == id);
                if (E.Count() == 1)
                {
                    moshtarekin p = new moshtarekin();
                    p = E.Single();
                    p.moshtarekin_b_id = null;
                }
                a.Books.Remove(q.Single());
                a.SaveChanges();
            }
        }
        public void updata (int id , Book u , updataed uhistory)
        {
            var q = a.Books.Where(i => i.book_id == id);
            if (q.Count() == 1)
            {
                Book p = new Book();
                p = q.Single();
                p.book_name = u.book_name;
                p.book_mozo = u.book_mozo;
                p.book_molaf = u.book_molaf;
                p.book_radeseni = u.book_radeseni;
                a.updataeds.Add(uhistory);
                a.SaveChanges();
            }

            //var q = a.Books.Where(i => i.book_id == id);
            //if (q.Count() == 1)
            //{
            //    a.updataeds.Add(uhistory);
            //    a.Books.Add(u);
            //    a.Books.Remove(q.Single());
            //    a.SaveChanges();
            //}
        }



        public void mcreate(moshtarekin c)
        {
            a.moshtarekins.Add(c);
            a.SaveChanges();
            //var q = a.Books.Where(i => i.book_name == bc.book_name);
            //if (q.Count() == 1)
            //{
            //    Book p = new Book();
            //    p = q.Single();
            //    p.moshtarekin_id = c.moshtarekin_id;

            //    a.SaveChanges();
            //}
            
            
        }
        public void mupdata(int id, moshtarekin u, updataed uhistory)
        {
            var q = a.moshtarekins.Where(i => i.moshtarekin_id == id);
            if (q.Count() == 1)
            {
                moshtarekin p = new moshtarekin();
                p = q.Single();
                p.moshtarekin_name = u.moshtarekin_name;
                p.moshtarekin_family = u.moshtarekin_family;
                p.moshtarekin_number = u.moshtarekin_number;
                p.moshtarekin_age = u.moshtarekin_age;
                p.moshtarekin_codmeli = u.moshtarekin_codmeli;
                p.moshtarekin_start = u.moshtarekin_start;
                p.moshtarekin_timeago = u.moshtarekin_timeago;
                a.updataeds.Add(uhistory);
                a.SaveChanges();
            }
        }
        public void mdelete(int id, deleted d)
        {
            var q = a.moshtarekins.Where(i => i.moshtarekin_id == id);
            if (q.Count() == 1)
            {
                a.deleteds.Add(d);
                var e = a.trusts.Where(i => i.trust_mokhatabin_id == id);
                if (e.Count() == 1)
                {
                    a.trusts.Remove(e.Single());
                    //a.SaveChanges();
                }
                var E = a.Books.Where(i => i.book_m_id == id);
                if (E.Count() == 1)
                {
                    Book p = new Book();
                    p = E.Single();
                    p.book_m_id = null;
                }
                a.moshtarekins.Remove(q.Single());
                a.SaveChanges();
            }
        }



        public void tcreate(trust c)
        {
            a.trusts.Add(c);
            var q = a.Books.Where(i => i.book_id == c.trust_book_id);
            if (q.Count() == 1)
            {
                Book p = new Book();
                p = q.Single();
                p.book_m_id = c.trust_mokhatabin_id;
            }
            var Q = a.moshtarekins.Where(i => i.moshtarekin_id == c.trust_mokhatabin_id);
            if (Q.Count() == 1)
            {
                moshtarekin p = new moshtarekin();
                p = Q.Single();
                p.moshtarekin_b_id = c.trust_book_id;
            }
            a.SaveChanges();
        }
        public void tupdata(int id,string bo , string mo ,string nm , string nb ,trust u)
        {
            var q = a.trusts.Where(i => i.trust_id == id);
            if (q.Count() == 1)
            {
                trust p = new trust();
                p = q.Single();
                p.trust_mokhatabin_id = u.trust_mokhatabin_id;
                p.trust_book_id = u.trust_book_id;
                p.trust_timestart = u.trust_timestart;
                p.trust_timeend = u.trust_timeend;
                p.trust_later = u.trust_later;
                a.SaveChanges();
            }
            var w = a.Books.Where(i => i.book_id == u.trust_book_id);
            if (w.Count() == 1)
            {
                Book p = new Book();
                p = w.Single();
                p.book_m_id = u.trust_mokhatabin_id;

                a.SaveChanges();
            }
            var W = a.moshtarekins.Where(i => i.moshtarekin_id == u.trust_mokhatabin_id);
            if (W.Count() == 1)
            {
                moshtarekin p = new moshtarekin();
                p = W.Single();
                p.moshtarekin_b_id = u.trust_book_id;

                a.SaveChanges();
            }

            if (bo != nb)
            {
                var vbo = a.Books.Where(i => i.book_name.ToString() == bo);
                if (vbo.Count() == 1)
                {
                    Book p = new Book();
                    p = vbo.Single();
                    p.book_m_id = null;;

                    a.SaveChanges();
                }
            }
            if (mo != nm)
            {
                var vmo = a.moshtarekins.Where(i => (i.moshtarekin_name.ToString() + " " + i.moshtarekin_family.ToString()) == mo);
                if (vmo.Count() == 1)
                {
                    moshtarekin p = new moshtarekin();
                    p = vmo.Single();
                    p.moshtarekin_b_id = null;

                    a.SaveChanges();
                }
            }
        }
        public void tdelete(int id)
        {
            //foreach (var ti in a.trusts)
            //{
            //    if (ti.trust_id == id)
            //    {
            //        var w = a.Books.Where(i => i.book_id == ti.trust_book_id);
            //        if (w.Count() == 1)
            //        {
            //            Book p = new Book();
            //            p = w.Single();
            //            p.book_m_id = null;
            //        }
            //        var W = a.moshtarekins.Where(i => i.moshtarekin_id == ti.trust_mokhatabin_id);
            //        if (W.Count() == 1)
            //        {
            //            moshtarekin p = new moshtarekin();
            //            p = W.Single();
            //            p.moshtarekin_b_id = null;
            //        }
            //    }
            //}

            var q = a.trusts.Where(i => i.trust_id == id);
            if (q.Count() == 1)
            {
                trust ti = new trust();
                ti = q.Single();
                var w = a.Books.Where(i => i.book_id == ti.trust_book_id);
                if (w.Count() == 1)
                {
                    Book p = new Book();
                    p = w.Single();
                    p.book_m_id = null;
                }
                var W = a.moshtarekins.Where(i => i.moshtarekin_id == ti.trust_mokhatabin_id);
                if (W.Count() == 1)
                {
                    moshtarekin p = new moshtarekin();
                    p = W.Single();
                    p.moshtarekin_b_id = null;
                }

                a.trusts.Remove(q.Single());
                a.SaveChanges();
            }
        }



        public void acreate(admin c)
        {
            a.admins.Add(c);
            a.SaveChanges();
        }
        public void aupdata(int id, admin u, updataed uhistory)
        {
            var q = a.admins.Where(i => i.admin_id == id);
            if (q.Count() == 1)
            {
                admin p = new admin();
                p = q.Single();
                p.admin_user = u.admin_user;
                a.updataeds.Add(uhistory);
                a.SaveChanges();
            }
        }
        public void adelete(int id, deleted d)
        {
            var q = a.admins.Where(i => i.admin_id == id);
            if (q.Count() == 1)
            {
                a.deleteds.Add(d);
                a.admins.Remove(q.Single());
                a.SaveChanges();
            }
        }
        public void atem(int temid , string newtem)
        {
            var q = a.admins.Where(i => i.admin_id == temid);
            if (q.Count() == 1)
            {
                admin p = new admin();
                p = q.Single();
                p.tem = newtem;
                a.SaveChanges();
            }
        }



        public void Backup(string filename)
        {
            //Data Source =.; Initial Catalog = Ketabkhone; Integrated Security = True
            //"data source=.;initial catalog=Ketabkhone;integrated security=True;multipleactiveresultsets=True"
            string BackUpConString = "data source=(local);initial catalog=Ketabkhone;integrated security=True;MultipleActiveResultSets=True;";
            using (SqlConnection con = new SqlConnection(BackUpConString))
            {
                ServerConnection srvConn = new ServerConnection(con);
                Server srvr = new Server(srvConn);

                if (srvr != null)
                {
                    try
                    {
                        Backup bkpDatabase = new Backup();
                        bkpDatabase.Action = BackupActionType.Database;
                        bkpDatabase.Database = "Ketabkhone";

                        BackupDeviceItem bkpDevice = new BackupDeviceItem(filename, DeviceType.File);
                        bkpDatabase.Devices.Add(bkpDevice);
                        bkpDatabase.SqlBackup(srvr);

                        Entity.PBD.BR = "try";
                    }
                    catch
                    {
                        Entity.PBD.BR = "catch";
                    }
                }
            }
        }
        public void Restore(string filename)
        {

            string ReStoreConString = "Data Source=(local);Initial Catalog=master;Integrated Security=True";
            SqlConnection.ClearAllPools();
            using (SqlConnection con = new SqlConnection(ReStoreConString))
            {
                ServerConnection srvConn = new ServerConnection(con);
                Server srvr = new Server(srvConn);
                srvr.KillAllProcesses("Ketabkhone");
                if (srvr != null)
                {
                    try
                    {
                        Restore rstDatabase = new Restore();
                        rstDatabase.Action = RestoreActionType.Database;
                        rstDatabase.Database = "Ketabkhone";//Bayad ham nam ba Data base barname tanzim shavad

                        BackupDeviceItem bkpDevice = new BackupDeviceItem(filename, DeviceType.File);
                        rstDatabase.Devices.Add(bkpDevice);

                        rstDatabase.ReplaceDatabase = true;
                        rstDatabase.SqlRestore(srvr);

                        Entity.PBD.BR = "try";
                    }
                    catch (Exception e)
                    {
                        Entity.PBD.BR = "catch";
                        Entity.PBD.BE = e.ToString();
                    }
                }
            }



        }
        public void DeleteDatabase()
        {
            try
            {
                //var q = a.admins.Where(i => i.admin_id != 1);
                //if (q.Count() == 1)
                //{
                //    a.admins.Remove(q.Single());
                //    a.SaveChanges();
                //}


                //foreach (var i in a.admins)
                //{
                //    if (i.admin_id != 1)
                //    {
                //        a.admins.Remove(i);
                //        a.SaveChanges();
                //    }
                //}
                //foreach (var i in a.Books)
                //{
                //    a.Books.Remove(i);
                //    a.SaveChanges();
                //}
                //foreach (var i in a.trusts)
                //{
                //    a.trusts.Remove(i);
                //    a.SaveChanges();
                //}
                //foreach (var i in a.moshtarekins)
                //{
                //    a.moshtarekins.Remove(i);
                //    a.SaveChanges();
                //}              
                PBD.DD = 1;
            }
            catch 
            {
                PBD.DD = 0;
            }           
        }
    }
}
