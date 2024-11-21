using BeFaster.Runner.Exceptions;

namespace BeFaster.App.Solutions.CHK
{
    public static class CheckoutSolution
    {
        public static int ComputePrice(string? skus)
        {
            int count = 0;
            if (skus != null)
            {
                if (skus.Length > 0)
                {

                    if (skus.Any(x => x != 'A' && x != 'B' && x != 'C' && x != 'D'))
                    {
                        return -1;
                    }
                    else
                    {
                        int countA = skus.Count(x => x == 'A');
                        int countB = skus.Count(x => x == 'B');
                        int countC = skus.Count(x => x == 'C');
                        int countD = skus.Count(x => x == 'D');
                        count += countC * 20;
                        count += countD * 15;
                        int wholeA = countA / 3;
                        int decimalA = countA % 3;
                        int wholeB = countB / 2;
                        int decimalB = countB % 2;
                        count += wholeA * 130;
                        count += decimalA * 50;
                        count += wholeB * 45;
                        count += decimalB * 30;
                        return count;

                    }
                }
                else { return 0; }

            }
            else
            {
                return -1;

            }
            throw new SolutionNotImplementedException();
        }
    }
}
