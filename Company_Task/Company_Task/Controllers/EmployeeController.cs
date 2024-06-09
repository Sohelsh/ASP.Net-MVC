using Microsoft.AspNetCore.Mvc;
using Company_Task.Data;
using Company_Task.ViewModel;
using Company_Task.Repository;

namespace Company_Task.Controllers
{
    public class EmployeeController : Controller
    {
       // private readonly AppDbContext Context;

        private readonly iEmployeeRepository _employeeRepository;

        public EmployeeController(iEmployeeRepository employeeRepository)
        {
            _employeeRepository = employeeRepository;
        }
        //public EmployeeController(AppDbContext Context)
        //{
        //    this.Context = Context;
        //}
        
        public IActionResult CascadeDropdown()
        {
            return View();
        }
        //public JsonResult Country()
        //{
        //    var cnt = Context.Countries.ToList();
        //    return new JsonResult(cnt);
        //}

        //public JsonResult State(int id)
        //{
        //    var st = Context.States.Where(e => e.Country.Id == id).ToList();
        //    return new JsonResult(st);
        //}
        //public JsonResult City(int id)
        //{
        //    var ct = Context.Cities.Where(e => e.State.Id == id).ToList();
        //    return new JsonResult(ct);
        //}
        public async Task<IActionResult> Index()
        {
            var employees = await _employeeRepository.GetAllAsync();
            return View(employees);
        }

        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Add(EmployeeViewModel model)
        {
            if (!ModelState.IsValid) 
            {
                return View(model);
            }

            await _employeeRepository.AddAsync(model);

            return RedirectToAction("Index","Employee");
        }
    }
}
