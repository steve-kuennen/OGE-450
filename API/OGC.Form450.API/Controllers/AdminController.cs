using System;
using System.Linq;
using System.Security.Claims;
using System.Web;
using System.Web.Http;

using OGC.Data.SharePoint.Models;
using System.Collections.Generic;
using OGC.Data.SharePoint;

namespace OGC.Form450.API.Controllers
{
    public class AdminController : BaseController
    {
        [HttpGet]
        public IHttpActionResult Get(string a)
        {
            try
            {
                if (a.ToLower() == "sync")
                {
                    Employee.SyncUserProfilesToEmployees();

                    return Ok("OK");
                }
                else if (a.StartsWith("file"))
                {
                    var divs = a.Split(':');
                    var div = divs[1];

                    GenerateFormsByDivision(div);

                    return Ok("OK");
                }
                else if (a.StartsWith("278check"))
                {
                    Employee.UpdateFilerTypes();

                    return Ok("OK");
                }
                else if (a.StartsWith("status"))
                {
                    Employee.SyncEmployeeStatus();

                    return Ok("OK");
                }
                else if (a.StartsWith("profile"))
                {
                    Employee.UpdateNotStartedFormsAddProfileData();

                    return Ok("OK");
                }
                else if (a.StartsWith("discover"))
                {
                    SecurityGroupMapping.Discovery();

                    return Ok("OK");
                }
                else if (a.StartsWith("reset"))
                {
                    SecurityGroupMapping.ResetDiscovery();

                    return Ok("OK");
                }
                else if (a.StartsWith("notifications"))
                {
                    Notifications.UpdateInfo();

                    return Ok("OK");
                }
                else
                {
                    return BadRequest("No such action.");
                }
            }
            catch (Exception ex)
            {
                return HandleException(ex);
            }
        }

        public void GenerateFormsByDivision(string div)
        {
            var list = Employee.GetAll().Where(x => x.FilerType == Constants.FilerType._450_FILER && (x.Division.ToLower() == div.ToLower() || x.Division.ToLower().Contains(div.ToLower() + ",") || x.Division.ToLower().Contains(", " + div.ToLower()))).ToList();

            foreach (Employee emp in list)
            {
                try
                {
                    var form = OGEForm450.GetCurrentFormByUser(emp.AccountName);

                    if (form == null)
                    {
                        if (emp.ReportingStatus != Constants.ReportingStatus.NEW_ENTRANT)
                        {
                            emp.ReportingStatus = Constants.ReportingStatus.NEW_ENTRANT;
                            emp.Save();
                        }

                        Employee.GetEmployeeUserProfileInfo(emp);

                        form = OGEForm450.Create(emp);
                        form.ProcessEmails();
                    }
                }
                catch (Exception ex)
                {
                    HandleException(ex);
                }
            }
        }
    }
}
