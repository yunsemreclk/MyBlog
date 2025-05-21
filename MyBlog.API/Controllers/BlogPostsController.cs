using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MyBlog.Business.Abstract;
using MyBlog.DTO.DTOs.BlogPostDtos;
using MyBlog.Entity.Entities;
using System.Security.Claims;

namespace MyBlog.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BlogPostsController(IGenericService<BlogPost> _blogPostService, IMapper _mapper) : ControllerBase
    {
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var posts = await _blogPostService.TGetAllAsync();
            var mapped = _mapper.Map<List<BlogPostDto>>(posts);
            return Ok(mapped);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var post = await _blogPostService.TGetPostByIdAsync(id);
            if (post == null) return NotFound();
            var mapped = _mapper.Map<BlogPostDto>(post);
            return Ok(mapped);
        }

        [HttpGet("slug/{slug}")]
        public async Task<IActionResult> GetBySlug(string slug)
        {
            var post = await _blogPostService.GetBySlugAsync(slug);
            if (post == null) return NotFound();
            var mapped = _mapper.Map<BlogPostDto>(post);
            return Ok(mapped);
        }

        [HttpPost]
        [Authorize]
        public async Task<IActionResult> Create([FromBody] BlogPostCreateDto dto)
        {
            if (!ModelState.IsValid) return BadRequest(ModelState);

            var post = _mapper.Map<BlogPost>(dto);
            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            await _blogPostService.TCreateAsync(post, userId!);
            return StatusCode(201);
        }

        [HttpPut("{id}")]
        [Authorize]
        public async Task<IActionResult> Update(int id, [FromBody] BlogPostUpdateDto dto)
        {
            if (!ModelState.IsValid) return BadRequest(ModelState);

            var post = _mapper.Map<BlogPost>(dto);
            var updated = await _blogPostService.TUpdateAsync(id, post);
            if (updated == null) return NotFound();
            return NoContent();
        }

        [HttpDelete("{id}")]
        [Authorize]
        public async Task<IActionResult> Delete(int id)
        {
            var result = await _blogPostService.TDeleteAsync(id);
            if (!result) return NotFound();
            return NoContent();
        }
    }
}
