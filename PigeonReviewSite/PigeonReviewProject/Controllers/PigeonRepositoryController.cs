using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PigeonReviewProject.Dto;
using PigeonReviewProject.Interfaces;

namespace PigeonReviewProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PigeonRepositoryController : ControllerBase
    {
        private readonly IPigeonRepository pigeonRepository;
        private readonly IMapper mapper;

        public PigeonRepositoryController(IPigeonRepository pigeonRepository,IMapper mapper)
        {
            this.pigeonRepository = pigeonRepository;
            this.mapper = mapper;
        }
        [HttpGet("GetAll")]
        public IActionResult Get()
        {
            var pigeon=mapper.Map<List<PegionDto>>( pigeonRepository.GetPigeons());
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            return Ok(pigeon);
        }
        [HttpGet("GetById")]
        public IActionResult GetById(int pegId)
        {
            if (!pigeonRepository.IsPigeonExist(pegId))
            {
                return NotFound();
            }
            var pigeon =mapper.Map<PegionDto>( pigeonRepository.GetPigeon(pegId));
            
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            return Ok(pigeon);

        }

        [HttpGet("{PigeonId}/{rating}")]

        public IActionResult GetRating(int pegId)
        {

            if (!pigeonRepository.IsPigeonExist(pegId))
            {
                return NotFound();
            }
            var rating = pigeonRepository.GetPigeonRating(pegId);

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            return Ok(rating);


        }
    }
}
