namespace Orhanization.Core.CrossCuttingConcerns.Exceptions.Types;

public class BusinessException : Exception
{
    public BusinessException() { }

    public BusinessException(string? message) : base(message) { }

    public BusinessException(string? message, Exception? innerException) : base(message, innerException) { }
    public BusinessException(string? message, string? helpLink) : base(message)
    {
        this.HelpLink = helpLink;
    }
}

