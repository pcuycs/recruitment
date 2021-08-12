using CommandQuery;

namespace Recruitment.Contracts.Commands
{
    /// <summary>
    /// The calculate hash command
    /// </summary>
    public class CalculateHashCommand : ICommand<CalculateHash>
    {
        /// <summary>
        /// The login
        /// </summary>
        public string Login { get; set; }

        /// <summary>
        /// The password
        /// </summary>
        public string Password { get; set; }
    }

    /// <summary>
    /// The calculate hash
    /// </summary>
    public class CalculateHash
    {
        /// <summary>
        /// The login
        /// </summary>
        public string LoginHash { get; set; }

        /// <summary>
        /// The password
        /// </summary>
        public string PasswordHash { get; set; }
    }
}
