using BeFaster.Runner.Exceptions;

namespace BeFaster.App.Solutions.CHK
{
    public static class CheckoutSolution
    {
        public static int ComputePrice(string? skus)
        {
            int count = 0;
            if (skus != null && skus.Length > 0)
            {
                if (skus.Any(x => x != 'A' || x != 'B' || x != 'C' || x != 'D'))
                {
                    return -1;
                }
                else
                {
                    char[] charArray = new char[skus.Length];
                    int countA = skus.Count(x => x == 'A');
                    int countB = skus.Count(x => x == 'B');
                    int countC = skus.Count(x => x == 'C');
                    int countD = skus.Count(x => x == 'D');
                    

                }

            }
            else
            {
                return -1;

            }
            throw new SolutionNotImplementedException();
        }
    }
}




