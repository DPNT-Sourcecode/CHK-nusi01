using BeFaster.Runner.Exceptions;

namespace BeFaster.App.Solutions.CHK
{
    public static class CheckoutSolution
    {
        public static int ComputePrice(string? skus)
        {
            if (skus != null && skus.Length>0)
            {

            }
            else
            {
                return -1;

            }
            throw new SolutionNotImplementedException();
        }
    }
}

