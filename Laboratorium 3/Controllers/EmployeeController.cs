using Laboratorium_3.Models;
using Microsoft.AspNetCore.Mvc;
using System.Reflection;

namespace Laboratorium_3.Controllers
{
    public class EmployeeController : Controller
    {
        private readonly IEmployeeService _employeeService;

        public EmployeeController(IEmployeeService employeeService) {
            this._employeeService = employeeService;
        }

        public IActionResult Index()
        {
            return View(_employeeService.FindAll());
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Employee model)
        {
            if (ModelState.IsValid)
            {
                _employeeService.Add(model);
                return RedirectToAction("Index");
            }
            else
            {
                return View(model);
            }
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            Employee employee = _employeeService.FindById(id);
            if (employee!= null)
            {
                return View(employee);
            }
            else
            {
                return NotFound();
            };
        }

        [HttpPost]
        public IActionResult Edit(int id, Employee model)
        {
            Employee employee = _employeeService.FindById(id);
            if (employee != null)
            {
                model.Id = id;
                _employeeService.Update(model);
                return RedirectToAction("Index");
            }
            else
            {
                return NotFound();
            };
        }

        [HttpGet]
        public IActionResult Details(int id)
        {
            Employee employee = _employeeService.FindById(id);
            if (employee != null)
            {
                return View(employee);
            }
            else
            {
                return NotFound();
            };
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            Employee employee = _employeeService.FindById(id);
            if (employee != null)
            {
                return View(employee);
            }
            else
            {
                return NotFound();
            };
        }

        [HttpPost]
        public IActionResult DeleteConfirm(int id)
        {
            Employee employee = _employeeService.FindById(id);
            if (employee != null)
            {
                _employeeService.Delete(id);
                return RedirectToAction("Index");
            }
            else
            {
                return NotFound();
            };
        }

        //static Dictionary<int, Employee> _employees = new Dictionary<int, Employee>();

        //public IActionResult Index()
        //{
        //    return View(_employees);
        //}

        //[HttpGet]
        //public IActionResult Create()
        //{
        //    return View();
        //}

        //[HttpPost]
        //public IActionResult Create(Employee model)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        int id = _employees.Keys.Count != 0 ? _employees.Keys.Max() : 0;
        //        model.Id = id + 1;
        //        _employees.Add(model.Id, model);

        //        return RedirectToAction("Index");
        //    }
        //    else
        //    {
        //        return View(model);
        //    }
        //}

        //[HttpGet]
        //public IActionResult Edit(int id)
        //{

        //    if (_employees.Keys.Contains(id))
        //    {
        //        return View(_employees[id]);
        //    }
        //    else
        //    {
        //        return NotFound();
        //    };
        //}

        //[HttpPost]
        //public IActionResult Edit(int id, Employee employee)
        //{

        //    if (_employees.Keys.Contains(id))
        //    {
        //        employee.Id = id;
        //        _employees[id] = employee;
        //        return RedirectToAction("Index");
        //    }
        //    else
        //    {
        //        return NotFound();
        //    };
        //}

        //[HttpGet]
        //public IActionResult Details(int id)
        //{

        //    if (_employees.Keys.Contains(id))
        //    {
        //        return View(_employees[id]);
        //    }
        //    else
        //    {
        //        return NotFound();
        //    };
        //}

        //[HttpGet]
        //public IActionResult Delete(int id)
        //{

        //    if (_employees.Keys.Contains(id))
        //    {
        //        return View(_employees[id]);
        //    }
        //    else
        //    {
        //        return NotFound();
        //    };
        //}

        //[HttpPost]
        //public IActionResult DeleteConfirm(int id)
        //{

        //    if (_employees.Keys.Contains(id))
        //    {
        //        _employees.Remove(id);
        //        return RedirectToAction("Index");
        //    }
        //    else
        //    {
        //        return NotFound();
        //    };
        //}
    }
}
