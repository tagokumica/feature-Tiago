using System;
using System.Collections.Generic;
using Application.Interface;
using Application.ViewModel;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Api.Controllers
{
    [Route("api/cliente")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        private readonly ICustomerAppService _iCustomerAppService;

        public CustomerController(ICustomerAppService iCustomerAppService)
        {
            _iCustomerAppService = iCustomerAppService;
        }


        [HttpGet("listar-cliente")]
        public IEnumerable<CustomerViewModel> GetAll()
        {
            return _iCustomerAppService.GetAll();
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


        [HttpGet("obter-por-id/{id:guid}")]
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
