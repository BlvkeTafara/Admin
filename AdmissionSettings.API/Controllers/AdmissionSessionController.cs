
using AdmissionSettings.Domain.DTOs;
using AdmissionSettings.Domain.Entities;
using AdmissionSettings.Domain.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AdmissionSettings.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AdmissionSessionController : ControllerBase
    {
        private readonly IUnitOfWorkRepository _unitOfWork;

        public AdmissionSessionController(IUnitOfWorkRepository unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        [HttpGet]

        public ActionResult Get()
        {
            var admissionsessionFromRepo = _unitOfWork.AdmissionSession.GetAll();
            return Ok(admissionsessionFromRepo);
        }
        [HttpGet("{id}")]
        public ActionResult Getbycode(int id)
        {
            var admissionsessionFromRepo = _unitOfWork.AdmissionSession.GetById(id);
            return Ok(admissionsessionFromRepo);
        }
        [HttpPost ("Create")]
        public ActionResult Post(AdmissionSessionDto data)
        {
            _unitOfWork.AdmissionSession.Add(data);
            
            return Ok(); 
        }
        [HttpPut("Update")]
        public ActionResult Put(AdmissionSessionDto data)
        {
            _unitOfWork.AdmissionSession.Update(data);

            return Ok();
        }
        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            _unitOfWork.AdmissionSession.Remove(id);

            return Ok();
        }
    }
}
