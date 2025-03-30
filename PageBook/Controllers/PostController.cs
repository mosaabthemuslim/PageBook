using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using PageBook.Application.Posts.Commands.CreatePost;
using PageBook.Application.Posts.Commands.DeletePost;
using PageBook.Application.Posts.Commands.UpdatePost;
using PageBook.Application.Posts.Dtos;
using PageBook.Application.Posts.Queries.GetAllPosts;
using PageBook.Application.Posts.Queries.GetPostById;


namespace PageBook.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PostController(IMediator mediator) : ControllerBase
    {
        // GET: api/<PostController>
        [HttpGet]
        public async Task<ActionResult<IEnumerable<PostDto>>> GetAll([FromQuery] GetAllPostsQuery getAllPostsQuery)
        {

            var posts = await mediator.Send(getAllPostsQuery);
            return Ok(posts);
        }



        // GET api/<PostController>/5
        [HttpGet("{id}")]
        public async Task<ActionResult<PostDto>> Get([FromRoute] int id)
        {
            var post = await mediator.Send(new GetPostByIdQuery(id));
            return Ok(post);
        }

        // POST api/<PostController>
        [HttpPost]
        [Authorize]
        public async Task<IActionResult> Post(CreatePostCommand createPostCommand)
        {
            var id = await mediator.Send(createPostCommand);
            return CreatedAtAction(nameof(Get), new { id }, null);
        }

        // PUT api/<PostController>/5
        [HttpPatch("{id}")]
        [Authorize]
        public async Task<ActionResult> Patch([FromRoute] int id, UpdatePostCommand updatePostCommand)
        {
            updatePostCommand.Id = id;
            await mediator.Send(updatePostCommand);
            return NoContent();
        }

        // DELETE api/<PostController>/5
        [HttpDelete("{id}")]
        [Authorize]
        public async Task<ActionResult> Delete([FromRoute] int id)
        {
            await mediator.Send(new DeletePostCommand(id));
            return NoContent();
        }
    }
}
