using AutoWrapper.Wrappers;
using BlogApp.API.Authorized;
using BlogApp.API.Models.Post;
using BlogApp.Shared.Repositories;
using BlogApp.Shared.Utils;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogApp.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [CustomAuthorizeFilter]

    public class PostController : ControllerBase
    {
        private PostRepository _postRepository { get; }
        private ITokenManagement _tokenManagement;

        public PostController(PostRepository postRepository, ITokenManagement tokenManagement)
        {
            _postRepository = postRepository;
            _tokenManagement = tokenManagement;
        }

        [HttpPost]
        [Route("")]
        public async Task<ApiResponse> Post([FromBody] PostReq model)
        {
            try
            {
                var currentId = _tokenManagement.currentID();
                await _postRepository.CreatePostAsync(currentId, model.Content, model.Photo, model.Permission);
            }
            catch (Exception ex)
            {
                return new ApiResponse(ex.Message, (int)StatusCodeEnum.BadRequest);
            }
            return new ApiResponse((int)StatusCodeEnum.Ok);
        }

        [HttpDelete]
        [Route("{Id}")]
        public async Task<ApiResponse> Delete(string Id)
        {
            try
            {
                var result = await _postRepository.DeletePostAsync(Id);
                if (!result)
                    return new ApiResponse("Error when delete", (int)StatusCodeEnum.BadRequest);
            }
            catch (Exception ex)
            {
                return new ApiResponse(ex.Message, (int)StatusCodeEnum.BadRequest);
            }
            return new ApiResponse((int)StatusCodeEnum.Ok);
        }



    }
}
