using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using EncomDashboardCore.Data;
using EncomDashboardCore.Models;
using EncomDashboardCore.ViewModels;
using EncomDashboardCore.Code;
using System.Net.Http;

namespace EncomDashboardCore.Controllers
{
    public class ApplicationsController : Controller
    {
        private readonly EncomDashboardCoreDBcontext _context;

        public ApplicationsController(EncomDashboardCoreDBcontext context)
        {
            _context = context;
        }

        // GET: Applications
        public async Task<IActionResult> Index()
        {
            return View(await _context.Applications.ToListAsync());
        }


        // GET: Applications Status
        public async Task<IActionResult> Dashboard()
        {
            ViewBag.Result = "";
            List<ApplicationStatusVM> DashboardVMList = new List<ApplicationStatusVM>();
            var ApplicationCount = _context.Applications.Count();
            //var ApplicationSort = _context.Applications.Include(d => d.AppID); //returns IQueryable
            //ApplicationSort = ApplicationSort.OrderBy(r => r.AppName);
            //ApplicationIndexViewModel Item = new ApplicationIndexViewModel();
            //for (int m = 0; m < ApplicationCount; m++)
            string AppResult = "";
            foreach (var m in _context.Applications.Take(50).ToList())
            {
                ApplicationStatusVM Item = new ApplicationStatusVM();
                Item.AppID = m.AppID;
                Item.AppType = m.AppType;
                Item.AppName = m.AppName;
                Item.AppLocation = m.AppLocation;
                Item.AppInfo = m.AppInfo;
                Item.Status = m.Status;
                AppResult = GetAppStatus(m.AppLocation); 
                Item.ApplicationStatusResult = AppResult;
                DashboardVMList.Add(Item);
            }
    
            ViewBag.ApplicationCount = ApplicationCount;
            return View("Dashboard", DashboardVMList.ToList()); 
            //return View("Dashboard", ApplicationResultsList.ToList());
            //return View(await _context.Applications.ToListAsync());
        }

        public string GetAppStatus(string app)
        {
            string result = "0";
            int StatusCode = 12345;
            //ViewBag.Result = "";

            try
            {
                HttpClient client = new HttpClient();
                var appTest = client.GetAsync(app);
                StatusCode = (int)appTest.Result.StatusCode;
                result = StatusCode.ToString();
            }
            catch (Exception e)
            {
                result = "<font color='red'>ERROR: </font> " + app + " - " + e.ToString();
            }
            //result = StatusCode.ToString();
            

            if (result == "12345") {
                ViewBag.Result = "<font color='red'><b>" + app + " | " + "DOWN" + "<b></font>";
            }
            else if (result == "200")
            {
                ViewBag.Result = "<font color='green'><b>" + app + " | " + "ONLINE" + "<b></font>";
            } else
            {
                ViewBag.Result = "<font color='blue'>" +  app + " | " + "UNKNOWN" + result + "</font>";
            }

            return result;
        }









        // GET: Applications/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var application = await _context.Applications
                .FirstOrDefaultAsync(m => m.AppID == id);
            if (application == null)
            {
                return NotFound();
            }

            return View(application);
        }

        // GET: Applications/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Applications/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("AppID,AppType,AppName,AppLocation,AppInfo,Status")] Application application)
        {
            if (ModelState.IsValid)
            {
                _context.Add(application);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(application);
        }






        // GET: Applications/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var application = await _context.Applications.FindAsync(id);
            if (application == null)
            {
                return NotFound();
            }


            var EditVM = new EditApplicationVM();

            // <<(AppType DROP-DOWN)>>>
            //List<SelectListItem> AppTypeList = Code.FormItems.GetApplicationTypes3();
            List<SelectListItem> AppTypeList = new List<SelectListItem>{
            new SelectListItem { Value = "Application", Text = "Application" },
            new SelectListItem { Value = "Service", Text = "Service" },
            new SelectListItem { Value = "Website", Text = "Website" }
            };

            int AppTypeCount = AppTypeList.Count;
            ViewBag.AppTypeCount = AppTypeCount;

            foreach (SelectListItem item in AppTypeList.ToList())
            {
                if (application.AppType.Contains(item.Value)) //Find matching item for selected value
                {
                    AppTypeList.Add(new SelectListItem { Text = application.AppType.ToString(), Value = application.AppType.ToString(), Selected = (true) });
                }
                else
                {
                    AppTypeList.Add(new SelectListItem { Text = item.Value, Value = item.Value });
                }
            }



            // <<(AppStatus DROP-DOWN)>>>
            List<SelectListItem> AppStatusList = Code.FormItems.GetApplicationStatuses();
            foreach (SelectListItem item in AppStatusList.ToList())
            {
                if (application.Status.ToString().Contains(item.Value)) //Find matching item for selected value
                {
                    AppTypeList.Add(new SelectListItem { Text = application.Status.ToString(), Value = application.Status.ToString(), Selected = (true) });
                }
                else
                {
                    AppTypeList.Add(new SelectListItem { Text = item.Value, Value = item.Value });
                }
            }


            EditVM.AppID = Convert.ToInt32(id);
            EditVM.AppTypes = AppTypeList; //
            EditVM.AppName = application.AppName;
            EditVM.AppLocation = application.AppLocation;
            EditVM.AppInfo = application.AppInfo;
            EditVM.AppStatuses = AppStatusList;


            //return View(application);
            return View(EditVM);
        }













        // POST: Applications/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("AppID,AppType,AppName,AppLocation,AppInfo,Status")] Application application)
        {
            if (id != application.AppID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(application);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ApplicationExists(application.AppID))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(application);
        }

        // GET: Applications/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var application = await _context.Applications
                .FirstOrDefaultAsync(m => m.AppID == id);
            if (application == null)
            {
                return NotFound();
            }

            return View(application);
        }

        // POST: Applications/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var application = await _context.Applications.FindAsync(id);
            _context.Applications.Remove(application);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ApplicationExists(int id)
        {
            return _context.Applications.Any(e => e.AppID == id);
        }
    }
}
