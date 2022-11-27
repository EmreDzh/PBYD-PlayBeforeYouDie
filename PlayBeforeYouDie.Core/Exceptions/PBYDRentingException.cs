namespace PlayBeforeYouDie.Core.Exceptions;

public class PBYDRentingException : ApplicationException
{
    public PBYDRentingException()
    {
        
    }

    public PBYDRentingException(string errorMessage) : base(errorMessage)
    {
        
    }
}