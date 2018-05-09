using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Configuration;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using RestServices.Models;


namespace RestServices.Controllers
{
    public class EmployeeController : ApiController
    {
        
       
        public EmployeeController()
        {

        }

        [HttpGet]
        public IList<Employees> GetAll( )
        {
            
            //Employees emp = new Employees();
            

        SqlDataReader reader = null;
            List<Employees> emps = new List<Employees>();

            string connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                SqlCommand sqlCmd = new SqlCommand();
                sqlCmd.CommandType = CommandType.Text;
                sqlCmd.CommandText = "Select * from Employee";
                sqlCmd.Connection = conn;

                reader = sqlCmd.ExecuteReader();

                //Employees emp = null;

                while (reader.Read())
                    {
                        Employees emp = new Employees();

                        emp.Id = Convert.ToInt32(reader.GetValue(0));
                        emp.FirstName = reader.GetValue(1).ToString();
                        emp.LastName = reader.GetValue(2).ToString();
                        emp.address = reader.GetValue(3).ToString();
                        emp.phnNumber = reader.GetValue(4).ToString();
                        emp.Gender = reader.GetValue(5).ToString();
                    emps.Add(emp);

                    }

                return emps;
            }


        }
        [HttpGet]
        public Employees GetById(int id)
        {

            SqlDataReader reader = null;
            
            string connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

            SqlCommand sqlCmd = new SqlCommand();
            sqlCmd.CommandType = CommandType.Text;
            sqlCmd.CommandText = "Select * from Employee where EmpId=" + id + "";
            sqlCmd.Connection = conn;
            
            reader = sqlCmd.ExecuteReader();
            Employees emp = null;
            while (reader.Read())
            {
                emp = new Employees();
                emp.Id = Convert.ToInt32(reader.GetValue(0));
                emp.FirstName = reader.GetValue(1).ToString();
                emp.LastName = reader.GetValue(2).ToString();
                emp.address= reader.GetValue(3).ToString();
                emp.phnNumber= reader.GetValue(4).ToString();
                emp.Gender= reader.GetValue(5).ToString();
                

            }
            return emp;
           
           }


    }

        [HttpPost]
        public void AddEmployee(Employees employee)
        {

           

            string connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlCommand sqlCmd = new SqlCommand("INSERT INTO Employee (EmpFn,EmpLn,EmpAddress,EmpPhno,Gender) Values (@EmpFn,@EmpLn,@EmpAddress,@EmpPhno,@Gender)", conn);
                sqlCmd.CommandType = CommandType.Text;

                //sqlCmd.Connection = conn;


               // sqlCmd.Parameters.AddWithValue("@EmpId", employee.Id);
                sqlCmd.Parameters.AddWithValue("@EmpFn", employee.FirstName);
                sqlCmd.Parameters.AddWithValue("@EmpLn", employee.LastName);
                sqlCmd.Parameters.AddWithValue("@EmpAddress", employee.address);
                sqlCmd.Parameters.AddWithValue("@EmpPhNo", employee.phnNumber);
                sqlCmd.Parameters.AddWithValue("@Gender", employee.Gender);


                int rowInserted = sqlCmd.ExecuteNonQuery();
                
            }
        }

    }
}
