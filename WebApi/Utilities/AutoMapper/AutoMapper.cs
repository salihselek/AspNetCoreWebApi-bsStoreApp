using AutoMapper;
using Entities.DataTransferObjects;
using Entities.Models;

namespace WebApi.Utilities.AutoMapper
{
    public class AutoMapper : Profile
    {
        public AutoMapper()
        {
            CreateMap<BookDtoForUpdate, Book>().ReverseMap();
            CreateMap<BookDtoForInsertion, Book>();
            CreateMap<Book, BookDto>();
            CreateMap<UserForRegistrationDto, User>();
        }
    }
}
