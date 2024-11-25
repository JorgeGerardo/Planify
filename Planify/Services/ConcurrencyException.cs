using Microsoft.EntityFrameworkCore;
using System;
using System.Threading.Tasks;

namespace Planify.Services
{
    public class ConcurrencyException : Exception
    {
        public ConcurrencyException(string message, Exception innerException)
            : base(message, innerException) { }
    }
    public class Concurrency
    {

        public static async Task<ConcurrencyState> Check(Func<Task<int>> saveChanges)
        {
            try
            {
                await saveChanges();
                return ConcurrencyState.WithoutConcurrency;
            }
            catch (DbUpdateConcurrencyException)
            {
                return ConcurrencyState.ConcurrencyDetected;
            }
        }

        public static string ConflictMessage()
        {
            return "El registro fue modificado por otro usuario. " +
                    "Por favor, recargue la página y vuelva a intentarlo.";
        }

    }
    public enum ConcurrencyState
    {
        WithoutConcurrency,
        ConcurrencyDetected
    }

}
