using System;
using System.Collections.Generic;
using Application.Interface;
using Application.ViewModel;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers
{
    [Route("api/endereco")]
    [ApiController]
    public class AddressController : ControllerBase
    {
        private readonly ICustomerAppService _iCustomerAppService;
        private readonly IAddressAppService _iAddressAppService;

        public AddressController(ICustomerAppService iCustomerAppService, IAddressAppService iAddressAppService)
        {
            _iCustomerAppService = iCustomerAppService;
            _iAddressAppService = iAddressAppService;
        }


        [HttpGet("listar-endereco")]
        public IEnumerable<AddressViewModel> GetAll()
        {
            return _iAddressAppService.GetAll();
        }


        [HttpPost("cadastrar-endereco/{id:guid}")]
        public ActionResult<AddressViewModel> Insert(Guid id, AddressViewModel addressViewModel)
        {

            var customer = _iCustomerAppService.FindCustomer(id);

            addressViewModel.CustomerID = customer.CustomerID;
            if (ModelState.IsValid)
            {
                return _iAddressAppService.Insert(addressViewModel);

            }


            return CreatedAtAction("GetAll", new List<AddressViewModel>());
        }

        [HttpGet("detalhes/{id:guid}")]
        public ActionResult<AddressViewModel> FindbyId(Guid id)
        {

            if (id == Guid.Empty || id == Guid.NewGuid())
            {
                return NotFound();
            }

            var addressViewModel = _iAddressAppService.FindbyId(id);

            if (addressViewModel == null)
                return NotFound();


            return addressViewModel;


        }

        [HttpPut("atualizar-endereco/{id:guid}")]
        public ActionResult<AddressViewModel> Update(Guid id, AddressViewModel addressViewModel)
        {
            if (id != addressViewModel.AddressID)
            {
                return BadRequest();
            }

            if (ModelState.IsValid)
            {
                return _iAddressAppService.Update(addressViewModel);

            }

            return NoContent();
        }

        [HttpDelete("deletar-endereco/{id:guid}")]
        public ActionResult<CustomerViewModel> DeleteAddressbyCustomer(Guid id)
        {
            var customer = _iCustomerAppService.FindCustomer(id);

            if (customer == null)
            {
                return NotFound();
            }

            _iAddressAppService.DeleteAddressbyCustomer(id);

            return customer;
        }

    }
}
