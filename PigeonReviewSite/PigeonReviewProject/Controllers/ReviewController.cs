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
    //public class ReviewController : ControllerBase
    //{
    //    private readonly IReviewRepository reviewRepository;
    //    private readonly IMapper mapper;

    //    public ReviewController(IReviewRepository reviewRepository ,IMapper mapper)
    //    {
    //        this.reviewRepository = reviewRepository;
    //        this.mapper = mapper;
    //    }

    //    [HttpGet("GelAllReview")]
    //    public IActionResult GetAllOwner()
    //    {
    //        var reviews = mapper.Map<List<ReviewDto>>(reviewRepository
    //            .GetReviews());
    //        if (!ModelState.IsValid)
    //        {
    //            return BadRequest(ModelState);
    //        }
    //        return Ok(reviews);
    //    }

    //    [HttpGet("GetReviewById")]
    //    public IActionResult GetById(int reviweId)
    //    {
    //        if (!reviewRepository.ReviewExist(reviweId))
    //        {
    //            return NotFound();
    //        }
    //        var reviews = mapper.Map<ReviewDto>(reviewRepository.GetReview(reviweId));

    //        if (!ModelState.IsValid)
    //        {
    //            return BadRequest(ModelState);
    //        }

    //        return Ok(reviews);

    //    }

    //    [HttpGet("pigeon/{pigeonId}")]
    //    public IActionResult GetReviewsForAPigeon(int pigeonId)
    //    {
    //        var reviews = mapper.Map<List<ReviewDto>>(reviewRepository
    //            .GetReviewsofAPigeon(pigeonId));
    //        if (!ModelState.IsValid)
    //        {
    //            return BadRequest(ModelState);
    //        }
    //        return Ok(reviews);
    //    }


    //}
}
