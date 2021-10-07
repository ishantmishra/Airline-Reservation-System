using LoginAPI.Models;
using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace LoginAPI.Controllers
{
  public class RegisterController : ApiController
    {
    public HttpResponseMessage Get()
    {
      string query = @"
            select UserId,FullName,UserName,EmailId,PhoneNo,Password from
            dbo.Register
            ";
      DataTable table = new DataTable();
      using(var con= new SqlConnection(ConfigurationManager.
        ConnectionStrings["AirlineAppDB"].ConnectionString))
        using(var cmd= new SqlCommand(query,con))
        using (var da= new SqlDataAdapter(cmd))
      {
        cmd.CommandType = CommandType.Text;
        da.Fill(table);
      }

      return Request.CreateResponse(HttpStatusCode.OK, table);

    }

    public string Post(Registered reg)
    {
      try
      {
        string query = @"
            insert into dbo.Register values
            (
             '"+ reg.FullName + @"',
             '" + reg.UserName + @"',
             '" + reg.EmailId + @"',
             '" + reg.PhoneNo + @"',
             '" + reg.Password + @"'
            )
            ";

        DataTable table = new DataTable();
        using (var con = new SqlConnection(ConfigurationManager.
          ConnectionStrings["AirlineAppDB"].ConnectionString))
        using (var cmd = new SqlCommand(query, con))
        using (var da = new SqlDataAdapter(cmd))
        {
          cmd.CommandType = CommandType.Text;
          da.Fill(table);
        }

        return "Added Successfully";
      }
      catch(Exception)
      {
        return "Failed to Add";
      }

    }


    public string Put(Registered reg)
    {
      try
      {
        string query = @"
             update dbo.Register set
             FullName='" + reg.FullName + @"'
             ,UserName='" + reg.UserName + @"'
             ,EmailId='" + reg.EmailId + @"'
             ,PhoneNo='" + reg.PhoneNo + @"'
             ,Password='" + reg.Password + @"'
             where UserId=" + reg.UserId +@"
            ";

        DataTable table = new DataTable();
        using (var con = new SqlConnection(ConfigurationManager.
          ConnectionStrings["AirlineAppDB"].ConnectionString))
        using (var cmd = new SqlCommand(query, con))
        using (var da = new SqlDataAdapter(cmd))
        {
          cmd.CommandType = CommandType.Text;
          da.Fill(table);
        }

        return "Updated Successfully";
      }
      catch (Exception)
      {
        return "Failed to Update";
      }

    }



    public string Delete(int id)
    {
      try
      {
        string query = @"
             delete from dbo.Register
            where UserId=" + id + @"
            ";

        DataTable table = new DataTable();
        using (var con = new SqlConnection(ConfigurationManager.
          ConnectionStrings["AirlineAppDB"].ConnectionString))
        using (var cmd = new SqlCommand(query, con))
        using (var da = new SqlDataAdapter(cmd))
        {
          cmd.CommandType = CommandType.Text;
          da.Fill(table);
        }

        return "Deleted Successfully";
      }
      catch (Exception)
      {
        return "Failed to delete";
      }

    }
  }
}
