using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PigeonReviewProject.Dto;
using PigeonReviewProject.Interfaces;
using PigeonReviewProject.Repositories;

namespace PigeonReviewProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DistrictController : ControllerBase
    {
        private readonly IDistrictRepository districtRepository;
        private readonly IMapper mapper;

        public DistrictController(IDistrictRepository districtRepository,IMapper mapper)
        {
            this.districtRepository = districtRepository;
            this.mapper = mapper;
        }
        [HttpGet("GetAllDistricts")]
        public IActionResult GetDistricts()
        {
            var districts = mapper.Map<List<DistrictDto>>(districtRepository
                .GetAllDistricts());
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            return Ok(districts);
        }

        [HttpGet("GetDistrictById")]
        public IActionResult GetById(int districtId)
        {
            if (!districtRepository.DistrictExist(districtId))
            {
                return NotFound();
            }
            var district = mapper.Map<DistrictDto>(districtRepository
                .GetDistrictById(districtId));

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            return Ok(district);

        }

        [HttpGet("/Owners/{OwnersById}")]
        public IActionResult GetOwnersFromADistrict(int ownerId)
        {
            var district = mapper.Map<List<DistrictDto>>(districtRepository
                .GetOwnersFromADistrict(ownerId));

            if (!ModelState.IsValid)
                return BadRequest(ModelState);


            return Ok(district);
        }


    }
}
