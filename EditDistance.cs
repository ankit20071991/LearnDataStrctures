using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DS101
{
    public class EditDistance
    {
        public static int EditDistanceFunction(string s1, string s2, int ICost, int RCost, int DCost)
        {
            int colSat = s1.Length + 1;
            int rowSun = s2.Length + 1;

            Operation[,] distanceMatrix = new Operation[rowSun, colSat];

            for (int i = 0; i < colSat; i++)
            {
                distanceMatrix[0, i] = new Operation(i, 'I');
            }
            for (int j = 0; j < rowSun; j++)
            {
                distanceMatrix[j, 0] = new Operation(j, 'I');
            }

            for (int i = 1; i < rowSun; i++)
            {
                for (int j = 1; j < colSat; j++)
                {
                    int rightCost = distanceMatrix[i, j - 1].value + ICost;
                    int downCost = distanceMatrix[i - 1, j].value + DCost;
                    int diagonalCOst = distanceMatrix[i - 1, j - 1].value + (s1[j - 1] == s2[i - 1] ? 0 : RCost);

                    if (rightCost < downCost && rightCost < diagonalCOst)
                        distanceMatrix[i, j] = new Operation(rightCost, 'I');
                    else if (downCost < rightCost && downCost < diagonalCOst)
                        distanceMatrix[i, j] = new Operation(downCost, 'D');
                    else if (diagonalCOst < downCost && diagonalCOst < rightCost && s1[j - 1] == s2[i - 1])
                        distanceMatrix[i, j] = new Operation(diagonalCOst, 'C');
                    else
                        distanceMatrix[i, j] = new Operation(diagonalCOst, 'R');
                }
            }
            while (colSat > 0 && rowSun > 0)
            {
                Console.Write(distanceMatrix[rowSun - 1, colSat - 1].operation + "->");

                switch (distanceMatrix[rowSun - 1, colSat - 1].operation)
                {
                    case 'I':
                        colSat--;
                        break;
                    case 'R':
                        rowSun--;
                        colSat--;
                        break;
                    case 'D':
                        rowSun--;
                        break;
                    case 'C':
                        rowSun--;
                        colSat--;
                        break;
                }
            }
            return distanceMatrix[s2.Length, s1.Length].value;
        }
    }
    class Operation
    {
        public char operation;
        public int value;
        public Operation(int value, char operation)
        {
            this.operation = operation;
            this.value = value;
        }
    }
}
