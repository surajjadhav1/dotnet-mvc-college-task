namespace BasicWebApp.Controllers;
using BasicWebApp.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

public class DetailController:Controller
{
    
    [HttpGet]
    [Route("Detail/Details/{id}")]
    public IActionResult Details(string id)
    {
        var db = new MetMumbaiDbContext();

        var cid = id;

        //ViewBag.cid = cid;
        ViewBag.model = db.Students
                   .Where(p=>p.CourseId==cid)
                   //.Include(p=>p.Students)
                   .ToList();
        
        return View("Details");
    }
}