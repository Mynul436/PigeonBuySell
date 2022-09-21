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
    //public class ReviewerController : ControllerBase
    //{
    //    private readonly IReviewerRepository reviewerRepository;
    //    private readonly IMapper mapper;

    //    public ReviewerController(IReviewerRepository reviewerRepository,IMapper mapper)
    //    {
    //        this.reviewerRepository = reviewerRepository;
    //        this.mapper = mapper;
    //    }

    //    [HttpGet("GelAllReviewer")]
    //    public IActionResult GetAllOwner()
    //    {
    //        var reviewers = mapper.Map<List<ReviewerDto>>(reviewerRepository
    //            .GetAllReviewers());
    //        if (!ModelState.IsValid)
    //        {
    //            return BadRequest(ModelState);
    //        }
    //        return Ok(reviewers);
    //    }

    //    [HttpGet("GetById")]
    //    public IActionResult GetById(int reviewerId)
    //    {
    //        if (!reviewerRepository.IsReviewerExist(reviewerId))
    //        {
    //            return NotFound();
    //        }
    //        var reviewer = mapper.Map<ReviewerDto>(reviewerRepository.GetReviewerById(reviewerId));

    //        if (!ModelState.IsValid)
    //        {
    //            return BadRequest(ModelState);
    //        }

    //        return Ok(reviewer);

    //    }
    //    [HttpGet("{reviewerId}/reviews")]
    //    public IActionResult GetReviewsByReviewer(int reviewerId)
    //    {
    //        if (!reviewerRepository.IsReviewerExist(reviewerId))
    //        {
    //            return NotFound();
    //        }
    //        var reviews = mapper.Map <List< ReviewerDto >>( reviewerRepository
    //            .GetReviewsReviewers(reviewerId));

    //        if (!ModelState.IsValid)
    //        {
    //            return BadRequest(ModelState);
    //        }
    //        return Ok(reviews);
    //    }

   // }
}
