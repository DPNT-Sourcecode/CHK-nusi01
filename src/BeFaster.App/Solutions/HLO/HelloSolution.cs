using BeFaster.Runner.Exceptions;

namespace BeFaster.App.Solutions.HLO
{
    public static class HelloSolution
    {
        public static string Hello(string? friendName)
        {
            if (friendName != null) { 
                return friendName;
            }
            throw new SolutionNotImplementedException();
        }
    }
}

