using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LoginAPI.Models
{
  public class Registered
  {
    public int UserId { get; set; }
    public string FullName { get; set; }
    public string UserName { get; set; }
    public string EmailId { get; set; }
    public string PhoneNo { get; set; }
    public string Password { get; set; }
  }
}
