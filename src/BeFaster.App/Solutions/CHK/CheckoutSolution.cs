using BeFaster.Runner.Exceptions;

namespace BeFaster.App.Solutions.CHK
{
    public static class CheckoutSolution
    {
        public static int ComputePrice(string? skus)
        {
            if (skus != null && skus.Length > 0)
            {
                char[] charArray = new char[skus.Length];
                int countA = skus.Count(x => x == 'A');
                int countB = skus.Count(x => x == 'A');
                int countC = skus.Count(x => x == 'A');
                int countD = skus.Count(x => x == 'A');

            }
            else
            {
                return -1;

            }
            throw new SolutionNotImplementedException();
        }
    }
}



