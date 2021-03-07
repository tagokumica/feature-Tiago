using System;
using System.Collections.Generic;
using System.Linq;
using Application.Interface;
using Application.ViewModel;
using Domain.Interface.Notification;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Api.Controllers
{
    [Route("api/cliente")]
    [ApiController]
    public class CustomerController : BaseController
    {
        private readonly ICustomerAppService _iCustomerAppService;
        private readonly INotification _notification;

        public CustomerController(INotification iNotification, ICustomerAppService iCustomerAppService, INotification notification) : base(iNotification)
        {
            _iCustomerAppService = iCustomerAppService;
            _notification = notification;
        }


        [HttpGet("listar-cliente")]
        public IEnumerable<CustomerViewModel> GetAll()
        {
            var customer = _iCustomerAppService.GetAll();
            return customer.Select(s => new CustomerViewModel
            {
                Name = customer.First().Name
            });
        }


        [HttpGet("listar-cliente-por-endereco/{id:guid}")]
        public IEnumerable<CustomerViewModel> GetCustomerbyAddress(Guid id)
        {
            return _iCustomerAppService.GetCustomerbyAddress(id);
        }

        [HttpGet("listar-cliente-por-telefone/{id:guid}")]
        public IEnumerable<CustomerViewModel> GetCustomerbyPhone(Guid id)
        {
            return _iCustomerAppService.GetCustomerbyPhone(id);
        }


        [HttpPost("cadastrar-cliente")]
        public  ActionResult<CustomerViewModel> Insert(CustomerViewModel customerViewModel)
        {
            if (ModelState.IsValid)
            {
                return _iCustomerAppService.Insert(customerViewModel);
                
            

            }


            return CreatedAtAction("GetAll", new List<CustomerViewModel>());
        }


        [HttpGet("detalhes/{id:guid}")]
        public ActionResult<CustomerViewModel> FindbyId(Guid id)
        {

            if (id == Guid.Empty || id == Guid.NewGuid())
            {
                return NotFound();
            }

            var customerViewModel = _iCustomerAppService.FindbyId(id);

            if (customerViewModel == null)
                return NotFound();
            

            return customerViewModel;

            
        }

        [HttpPut("atualizar-cliente/{id:guid}")]
        public ActionResult<CustomerViewModel> Update(Guid id, CustomerViewModel customerViewModel)
        {
            if (id != customerViewModel.CustomerID)
            {
                return BadRequest();
            }

            if (ModelState.IsValid)
            {
                return _iCustomerAppService.Update(customerViewModel);

            }

            return NoContent();
        }

        [HttpGet("obter-por-cliente/{id:guid}")]
        public ActionResult<CustomerViewModel> FindCustomer(Guid id)
        {

            if (id == Guid.Empty || id == Guid.NewGuid())
            {
                return NotFound();
            }

            var customerViewModel = _iCustomerAppService.FindCustomer(id);

            if (customerViewModel == null)
                return NotFound();


            return customerViewModel;


        }

    }
}
