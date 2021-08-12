using CommandQuery.Exceptions;

namespace Recruitment.Handlers
{
    public class CalculateHashCommandException : CommandException
    {
        public int ErrorCode { get; }

        /// <summary>
        /// 
        /// </summary>
        public string Help { get; }


        /// <summary>
        /// The constructor with parammeters
        /// </summary>
        /// <param name="message"></param>
        /// <param name="errorCode"></param>
        /// <param name="help"></param>
        public CalculateHashCommandException(string message, int errorCode, string help) : base(message)
        {
            ErrorCode = errorCode;
            Help = help;
        }

        /// <summary>
        /// The constructor
        /// </summary>
        /// <param name="message"></param>
        public CalculateHashCommandException(string message) : base(message)
        {

        }
    }
}
