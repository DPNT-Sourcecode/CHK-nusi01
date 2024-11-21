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
                    // Converted to byte
                    if (skus.Any(x => x != 'A' &&  x != 'B' && x != 'C' && x != 'D' && x != 'E' && x != 'F' && x != 'G' && x != 'H' && x != 'I' && x != 'J' && x != 'K' && x != 'L' && x != 'M' && x != 'N' && x != 'O' && x != 'P' && x != 'Q' && x != 'R' && x != 'S' && x != 'T' && x != 'U' && x != 'V' && x != 'W' && x != 'X' && x != 'Y' && x != 'Z'))
                    {
                        return -1;
                    }
                    else
                    {
                        int countA = skus.Count(x => x == 'A');
                        int countB = skus.Count(x => x == 'B');
                        int countC = skus.Count(x => x == 'C');
                        int countD = skus.Count(x => x == 'D');
                        int countE = skus.Count(x => x == 'E');
                        int countF = skus.Count(x => x == 'F');
                        int countG = skus.Count(x => x == 'G');
                        int countH = skus.Count(x => x == 'H');
                        int countI = skus.Count(x => x == 'I');
                        int countJ = skus.Count(x => x == 'J');
                        int countK = skus.Count(x => x == 'K');
                        int countL = skus.Count(x => x == 'L');
                        int countM = skus.Count(x => x == 'M');
                        int countN = skus.Count(x => x == 'N');
                        int countO = skus.Count(x => x == 'O');
                        int countP = skus.Count(x => x == 'P');
                        int countQ = skus.Count(x => x == 'Q');
                        int countR = skus.Count(x => x == 'R');
                        int countS = skus.Count(x => x == 'S');
                        int countT = skus.Count(x => x == 'T');
                        int countU = skus.Count(x => x == 'U');
                        int countV = skus.Count(x => x == 'V');
                        int countW = skus.Count(x => x == 'W');
                        int countX = skus.Count(x => x == 'X');
                        int countY = skus.Count(x => x == 'Y');
                        int countZ = skus.Count(x => x == 'Z');

                        int wholeA5 = countA / 5;
                        int decimalA5 = countA % 5;
                        int wholeA3 = decimalA5 / 3;
                        int decimalA3 = decimalA5 % 3;
                        count += wholeA5 * 200;
                        count += wholeA3 * 130;
                        count += decimalA3 * 50;

                        int wholeE = countE / 2;
                        if (countB >= wholeE)
                        {
                            countB -= wholeE;
                        }
                        else
                        {
                            countB = 0;
                        }
                        int wholeB = countB / 2;
                        int decimalB = countB % 2;
                        count += wholeB * 45;
                        count += decimalB * 30;

                        count += countC * 20;
                        count += countD * 15;
                        count += countE * 40;

                        int wholeF = countF / 3;
                        count += (countF - wholeF) * 10;

                        count += countG * 20;

                        int wholeH10 = countH / 10;
                        int decimalH10 = countH % 10;
                        int wholeH5 = decimalH10 / 5;
                        int decimalH5 = decimalH10 % 5;
                        count += ((wholeH10 * 80) + (wholeH5 * 45) + (decimalH5 * 10));

                        count += countI * 35;
                        count += countJ * 60;

                        int wholeK = countK / 2;
                        int decimalK = countK % 2;
                        count += ((wholeK * 150) + (decimalK * 80));

                        count += countL * 90;

                        int wholeN = countN / 3;
                        if (countM >= wholeN)
                        {
                            countM -= wholeN;
                        }
                        else
                        {
                            countM = 0;
                        }
                        count += countM * 15;
                        count += countN * 40;
                        count += countO * 10;

                        int wholeP = countP / 5;
                        int decimalP = countP % 5;
                        count += ((wholeP * 200) + (decimalP * 50));

                        int wholeR = countR / 3;
                        if (countQ >= wholeR)
                        {
                            countQ -= wholeR;
                        }
                        else
                        {
                            countQ = 0;
                        }
                        int wholeQ = countQ / 3;
                        int decimalQ = countQ % 3;
                        count += ((wholeQ * 80) + (decimalQ * 30));

                        count += countR * 50;
                        count += countS * 30;
                        count += countT * 20;

                        int wholeU = countU / 3;
                        if (countU >= wholeU)
                        {
                            countU -= wholeU;
                        }
                        else
                        {
                            countU = 0;
                        }
                        count += countU * 40;

                        int wholeV3 = countV / 3;
                        int decimalV3=countV % 3;
                        int wholeV2 = decimalV3 / 2;
                        int decimalV2 = decimalV3 % 2;
                        count += ((wholeV3 * 130) + (wholeV2 * 90) + (decimalV2 * 50));

                        count += countW * 20;
                        count += countX * 90;
                        count += countY * 10;
                        count += countZ * 50;
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
