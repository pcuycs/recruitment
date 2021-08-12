using System.Threading;
using System.Threading.Tasks;
using CommandQuery;
using Recruitment.Contracts.Commands;
using Recruitment.Common;

namespace Recruitment.Handlers.Commands
{
    public class CalculateHashCommandHandler : ICommandHandler<CalculateHashCommand, CalculateHash>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CalculateHashCommandHandler"/> class.
        /// </summary>
        public CalculateHashCommandHandler()
        {
        }

        /// <summary>
        /// Handles the asynchronous.
        /// </summary>
        /// <param name="command">The command.</param>
        /// <param name="cancellationToken">The cancellation token.</param>
        /// <returns></returns>
        /// <exception cref="CalculateHashCommandException">param cannot be null - 400 - Try setting the value to 'en-US'</exception>
        public async Task<CalculateHash> HandleAsync(CalculateHashCommand command, CancellationToken cancellationToken)
        {
            if (command == null) throw new CalculateHashCommandException("param cannot be null", 400, "Try setting the value to 'en-US'");

            var result = new CalculateHash
            {
                LoginHash = command.Login.CreateMD5Hash(),
                PasswordHash = command.Password.CreateMD5Hash()
            };

            return await Task.FromResult(result);
        }
    }
}
