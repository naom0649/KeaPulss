using KeaPulss.Models.API;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Umbraco.Cms.Core.Scoping;
using Umbraco.Cms.Web.Common.Controllers;
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

        public IActionResult Index(PostStudentApplicationsRequest postBody)
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

        //[Route("/:id")]
        //public IActionResult Get(int id)
        //{

        //}

    }
}
