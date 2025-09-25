using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using api.Models;
using api.Dtos.Comment;
namespace api.Mappers
{
    public static class CommentMapper
    {
        public static CommentDto ToCommentDto(this Comment commentModel)
        {
            return new CommentDto
            {
                Id = commentModel.Id,
                Title = commentModel.Title,
                Content = commentModel.Content,
                CreatedAt = commentModel.CreatedAt,
                CreatedBy = commentModel.AppUser.UserName,
                StockId = commentModel.StockId
            };
        }

        public static Comment ToCommentOnCreate(this CreateCommentDto commentDto, int stockId)
        {
            return new Comment
            {
                Title = commentDto.Title,
                Content = commentDto.Content,
                StockId = stockId,
            };
        }
       
          public static Comment ToCommentFromUpdate(this UpdateCommentRequestDto commentDto) {
            return new Comment
            {
                Title = commentDto.Title,
                Content = commentDto.Content,
            };
       }
    }
}