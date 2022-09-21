using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PigeonReviewProject.Dto;
using PigeonReviewProject.Interfaces;
using PigeonReviewProject.Repositories;

namespace PigeonReviewProject.Controllers
{
    //[Route("api/[controller]")]
    //[ApiController]
    //public class OwnersController : ControllerBase
    //{
    //    private readonly IOwnerRepository ownerRepository;
    //    private readonly IMapper mapper;

    //    public OwnersController(IOwnerRepository ownerRepository, IMapper mapper)
    //    {
    //        this.ownerRepository = ownerRepository;
    //        this.mapper = mapper;
    //    }

    //    [HttpGet("GelAllOwner")]
    //    public IActionResult GetAllOwner()
    //    {
    //        var owners = mapper.Map<List<OwnerDto>>(ownerRepository
    //            .GetAllOwner());
    //        if (!ModelState.IsValid)
    //        {
    //            return BadRequest(ModelState);
    //        }
    //        return Ok(owners);
    //    }

    //    [HttpGet("GetById")]
    //    public IActionResult GetById(int ownerId)
    //    {
    //        if (!ownerRepository.OwnerExists(ownerId))
    //        {
    //            return NotFound();
    //        }
    //        var owner = mapper.Map<OwnerDto>(ownerRepository.GetOwner(ownerId));

    //        if (!ModelState.IsValid)
    //        {
    //            return BadRequest(ModelState);
    //        }

    //        return Ok(owner);

    //    }

    //    [HttpGet("{ownerId}/Pigeon")]

    //    public IActionResult GetPigeonByOwner(int ownerId)
    //    {
    //        if (!ownerRepository.OwnerExists(ownerId))
    //        {
    //            return NotFound();
    //        }

    //        var owner = mapper.Map<OwnerDto>(ownerRepository
    //            .GetPigeonOfAOwner(ownerId));
    //        if (!ModelState.IsValid)
    //            return BadRequest(ModelState);

    //        return Ok(owner);
    //    }


    //    [HttpGet("{ownerId}/Pigeon")]

    //    public IActionResult GetOwnerOfAPigeon(int pigeonId)
    //    {
    //        if (!ownerRepository.OwnerExists(pigeonId))
    //        {
    //            return NotFound();
    //        }

    //        var owner = mapper.Map<OwnerDto>(ownerRepository
    //            .GetOwnerOfAPigeon(pigeonId));
    //        if (!ModelState.IsValid)
    //            return BadRequest(ModelState);

    //        return Ok(owner);
    //    }

    //}
}
