using System;
using Unity.Services.Core;

namespace Unity.Services.Authentication
{
    /// <summary>
    /// AuthenticationException represents a runtime exception from authentication.
    /// </summary>
    public class AuthenticationException : RequestFailedException
    {
        /// <summary>
        /// Constructor of the AuthenticationException with the error code, a message, and inner exception.
        /// </summary>
        /// <param name="errorCode">The error code for AuthenticationException.</param>
        /// <param name="message">The additional message that helps to debug the error.</param>
        /// <param name="innerException">The inner exception reference.</param>
        AuthenticationException(int errorCode, string message, Exception innerException = null)
            : base(errorCode, message, innerException)
        {
        }

        /// <summary>
        /// Creates the exception base on errorCode range.
        /// If the errorCode is less than AuthenticationErrorCodes.MinValue it creates a <see cref="RequestFailedException"/>.
        /// Otherwise it creates an <see cref="AuthenticationException"/>
        /// </summary>
        public static RequestFailedException Create(int errorCode, string message, Exception innerException = null)
        {
            if (errorCode < AuthenticationErrorCodes.MinValue)
            {
                return new RequestFailedException(errorCode, message, innerException);
            }
            else
            {
                return new AuthenticationException(errorCode, message, innerException);
            }
        }
    }
}
