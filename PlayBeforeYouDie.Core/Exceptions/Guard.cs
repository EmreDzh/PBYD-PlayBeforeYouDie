namespace PlayBeforeYouDie.Core.Exceptions;

public class Guard : IGuard
{
    public void AgainstNull<T>(T value, string? errorMessage = null)
    {
        if (value == null)
        {
            var excpetion = errorMessage == null
                ? new PBYDRentingException()
                : new PBYDRentingException(errorMessage);
            
            throw excpetion;
        }

    }
    
}