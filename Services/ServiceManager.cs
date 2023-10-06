using Services.Contracts;

namespace Services
{
    public class ServiceManager : IServiceManager
    {
        private readonly ICategoryService _categoryService;
        private readonly IBookService _bookService;
        private readonly IAuthenticationService _authenticationService;

        public ServiceManager(ICategoryService categoryService,
            IBookService bookService,
            IAuthenticationService authenticationService)
        {
            _categoryService = categoryService;
            _bookService = bookService;
            _authenticationService = authenticationService;
        }

        public IBookService BookService => _bookService;

        public IAuthenticationService AuthenticationService => _authenticationService;

        public ICategoryService CategoryService => _categoryService;
    }
}