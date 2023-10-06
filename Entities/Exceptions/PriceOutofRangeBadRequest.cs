namespace Entities.Exceptions
{
    public class PriceOutofRangeBadRequest : BadRequestException
    {
        public PriceOutofRangeBadRequest() : base("Maximum price should be less than 1000 and greater than 10.")
        {
        }
    }
}
