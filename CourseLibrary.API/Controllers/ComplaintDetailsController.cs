using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using CourseLibrary.API.Models;
using CourseLibrary.API.ResourceParameters;
using CourseLibrary.API.Services;
using Microsoft.AspNetCore.Mvc;

namespace CourseLibrary.API.Controllers
{
    [ApiController]
    [Route("api/complaintDetails")]
    public class ComplaintDetailsController : ControllerBase
    {
        private readonly IComplaintDetailRepository _complaintDetailRepository;
        private readonly IMapper _mapper;

        public ComplaintDetailsController(IComplaintDetailRepository complaintDetailRepository,
            IMapper mapper)
        {
            _complaintDetailRepository = complaintDetailRepository ??
                throw new ArgumentNullException(nameof(complaintDetailRepository));
            _mapper = mapper ??
                throw new ArgumentNullException(nameof(mapper));
        }

        [HttpGet("{emailId}")]
        public ActionResult<IEnumerable<ComplaintDetailDto>> GetAuthors(
            [FromRoute] string emailId)
        {
            var complaintDetailsFromRepo = _complaintDetailRepository.GetComplaintDetails(emailId);
            return Ok(_mapper.Map<IEnumerable<ComplaintDetailDto>>(complaintDetailsFromRepo));
        }
    }
}