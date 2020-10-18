using System;
using System.Collections.Generic;
using System.Text;

namespace UserRegistration
{
    public class CustomException : Exception
    {
        public enum ExceptionType
            {
                INVALID_FIRST_NAME,
                INVALID_LAST_NAME,
                INVALID_EMAIL,
                INVALID_MOBILENO,
                INVALID_PASSWORD
            }
            private ExceptionType type;
            public CustomException(ExceptionType Type, String message) : base(message)
            {
                this.type = Type;
            }
        }
}
