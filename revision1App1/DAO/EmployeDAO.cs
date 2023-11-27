using revision1App1.Models;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace revision1App1.DAO
{
    internal class EmployeDAO : IEmploye
    {
        private DatabaseHelper db;
        public EmployeDAO()
        {
            db = new DatabaseHelper();
        }
        public void Add(employer empl)
        {
            try
            {
                string sql = "INSERT INTO employer(nom,prenom,matricule) VALUES ('" + empl.nom + "','" + empl.prenom  + "','\n" + empl.matricule+"')";
                db.ExecuteUpdate(sql);
            }
            catch (Exception e)
            {

                throw e;
            }


        

    }

    public List<employer> FindAll()
        {
            try
            {
                List<employer> employers = new List<employer>();
                string sql = "SELECT * FROM employer";
                SqlDataReader dr = db.ExecuteReader(sql);
                while (dr.Read())
                {
                    employer et = new employer();
                    et.Id = dr.GetInt32(0);
                    et.nom = dr.GetString(1);
                    et.prenom = dr.GetString(2);
                    et.matricule = dr.GetString(3);
                    employers.Add(et);
                }
                dr.Close();
                return employers;
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }

        public employer FindByMatricule(string matricule)
        {
                try
            {
                employer et = null;
                string sql = "SELECT * FROM employer WHERE matricule='" + matricule + "'";
                SqlDataReader dr = db.ExecuteReader(sql);
                if (dr.Read())
                {
                    et = new employer();
                    et.Id = dr.GetInt32(0);
                    et.nom = dr.GetString(1);
                    et.prenom = dr.GetString(2);
                    
                    et.matricule = dr.GetString(3);

                }
                dr.Close();
                return et;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

       
    }
    }

