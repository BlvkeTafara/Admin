using AdmissionSettings.Domain.DTOs;
using AdmissionSettings.Domain.Entities;
using AdmissionSettings.Domain.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AdmissionSettings.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AdmissionSessionRequestController : ControllerBase
    {
        private readonly IUnitOfWorkRepository _unitOfWork;

        public AdmissionSessionRequestController(IUnitOfWorkRepository unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        [HttpGet]

        public ActionResult Get()
        {
            var admissionsessionrequestFromRepo = _unitOfWork.AdmissionSessionRequest.GetAll();
            return Ok(admissionsessionrequestFromRepo);
        }
        [HttpGet("{id}")]
        public ActionResult Getbycode(int id)
        {
            var admissionsessionrequestFromRepo = _unitOfWork.AdmissionSessionRequest.GetById(id);
            return Ok(admissionsessionrequestFromRepo);
        }
        [HttpPost("Create")]
        public ActionResult Post(AdmissionSessionRequestDto data)
        {
            _unitOfWork.AdmissionSessionRequest.Add(data);

            return Ok();
        }
        [HttpPut("Update")]
        public ActionResult Put(AdmissionSessionRequestDto data)
        {
            _unitOfWork.AdmissionSessionRequest.Update(data);

            return Ok();
        }
        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            _unitOfWork.AdmissionSessionRequest.Remove(id);

            return Ok();
        }
    }
    }
