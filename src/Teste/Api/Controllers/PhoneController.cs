using System;
using Application.Interface;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using Application.ViewModel;

namespace Api.Controllers
{
    [Route("api/telefone")]
    [ApiController]
    public class PhoneController : ControllerBase
    {

        private readonly ICustomerAppService _iCustomerAppService;
        private readonly IPhoneAppService _iPhoneAppService;

        public PhoneController(ICustomerAppService iCustomerAppService, IPhoneAppService iPhoneAppService)
        {
            _iCustomerAppService = iCustomerAppService;
            _iPhoneAppService = iPhoneAppService;
        }

        [HttpGet("listar-telefone")]
        public IEnumerable<PhoneViewModel> GetAll()
        {
            return _iPhoneAppService.GetAll();
        }


        [HttpPost("cadastrar-telefone/{id:guid}")]
        public ActionResult<PhoneViewModel> Insert(Guid id, PhoneViewModel phoneViewModel)
        {

            var customer = _iCustomerAppService.FindCustomer(id);

            phoneViewModel.CustomerID = customer.CustomerID;
            if (ModelState.IsValid)
            {
                return _iPhoneAppService.Insert(phoneViewModel);

            }


            return CreatedAtAction("GetAll", new List<PhoneViewModel>());
        }

        [HttpGet("detalhes/{id:guid}")]
        public ActionResult<PhoneViewModel> FindbyId(Guid id)
        {

            if (id == Guid.Empty || id == Guid.NewGuid())
            {
                return NotFound();
            }

            var phoneViewModel = _iPhoneAppService.FindbyId(id);

            if (phoneViewModel == null)
                return NotFound();


            return phoneViewModel;


        }

        [HttpPut("atualizar-telefone/{id:guid}")]
        public ActionResult<PhoneViewModel> Update(Guid id, PhoneViewModel phoneViewModel)
        {
            if (id != phoneViewModel.PhoneID)
            {
                return BadRequest();
            }

            if (ModelState.IsValid)
            {
                return _iPhoneAppService.Update(phoneViewModel);

            }

            return NoContent();
        }

        [HttpDelete("deletar-telefone/{id:guid}")]
        public ActionResult<CustomerViewModel> DeletePhonebyCustomer(Guid id)
        {
            var customer = _iCustomerAppService.FindCustomer(id);

            if (customer == null)
            {
                return NotFound();
            }

            _iPhoneAppService.DeletePhonebyCustomer(id);

            return customer;
        }

    }
}
