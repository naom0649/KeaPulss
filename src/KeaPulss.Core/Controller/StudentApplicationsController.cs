using KeaPulss.Models.API;
using Microsoft.AspNetCore.Mvc;

using Umbraco.Cms.Core.Scoping;
using Umbraco.Cms.Web.Common.Controllers;
using KeaPulss.Core.Migrations;
using static KeaPulss.Core.Migrations.AddStudentApplicationsTable;

namespace KeaPulss.Core.Controller
{
    [Route("api/applications")]
    public class StudentApplicationsController : UmbracoApiController
    {
        private readonly IScopeProvider _scopeProvider;

        public StudentApplicationsController(IScopeProvider scopeProvider)
        {
            _scopeProvider = scopeProvider;
        }

        // Metode til at hente alle ansøgninger
        [HttpGet]
        public IActionResult GetAllApplications()
        {
            using var scope = _scopeProvider.CreateScope();

            var applications = scope.Database.Fetch<StudentCommentSchema>();

            return Ok(applications);
        }

        // Metode til at oprette en ny ansøgning
        [HttpPost]
        public IActionResult CreateApplication(PostStudentApplicationsRequest postBody)
        {
            using var scope = _scopeProvider.CreateScope();
            var studentApplication = new StudentCommentSchema();
            studentApplication.stu_name = postBody.stu_name;
            studentApplication.mail = postBody.mail;
            studentApplication.position = postBody.posistion;
            studentApplication.about = postBody.about;
            studentApplication.reason = postBody.reason;

            scope.Database.Insert<StudentCommentSchema>(studentApplication);

            scope.Complete();

            return Ok();
        }

        // Metode til at slette en ansøgning baseret på ID
        [HttpDelete("{id}")]
        public IActionResult DeleteApplication(int id)
        {
            using var scope = _scopeProvider.CreateScope();
            var existingApplication = scope.Database.SingleOrDefault<StudentCommentSchema>("WHERE Id = @0", id);
           

            if (existingApplication == null)
            {
                return NotFound(); // Returner 404, hvis ansøgningen ikke findes
            }

            scope.Database.Delete(existingApplication);

            scope.Complete();

            return NoContent(); // Returner 204 No Content, da ansøgningen er blevet slettet
        }
    }
}
