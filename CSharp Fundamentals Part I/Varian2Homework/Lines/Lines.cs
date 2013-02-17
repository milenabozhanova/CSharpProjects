using System;

namespace Lines
{
    class Lines
    {
        static void Main()
        {
            char[,] matrix = new char[8, 8];
            int maxLen = 0;
            int cnt = 0;


            for (int i = 0; i < 8; i++)
            {
                int input = int.Parse(Console.ReadLine());
                string inputBinary = Convert.ToString(input, 2).PadLeft(8, '0');

                int subCnt = 0;
                for (int c = 0; c < 8; c++)
                {
                    matrix[i, c] = inputBinary[c];
                    if (matrix[i, c] == '1')
                    {
                        subCnt++;
                    }
                    else
                    {
                        if (subCnt > 0)
                        {
                            if (maxLen < subCnt)
                            {
                                cnt = 1;
                                maxLen = subCnt;
                            }
                            else if (maxLen == subCnt)
                            {
                                cnt++;
                            }
                            subCnt = 0;
                        }
                    }
                }
                if (subCnt > 0)
                {
                    if (maxLen < subCnt)
                    {
                        cnt = 1;
                        maxLen = subCnt;
                    }
                    else if (maxLen == subCnt)
                    {
                        cnt++;
                    }
                }
            }

            for (int x = 0; x < 8; x++)
            {
                int subCnt = 0;
                for (int y = 0; y < 8; y++)
                {
                    if (matrix[y, x] == '1')
                    {
                        subCnt++;
                    }
                    else
                    {
                        if (subCnt > 0)
                        {
                            if (maxLen < subCnt)
                            {
                                cnt = 1;
                                maxLen = subCnt;
                            }
                            else if (maxLen == subCnt)
                            {
                                cnt++;
                            }
                            subCnt = 0;
                        }
                    }
                }
                if (subCnt > 0)
                {
                    if (maxLen < subCnt)
                    {
                        cnt = 1;
                        maxLen = subCnt;
                    }
                    else if (maxLen == subCnt)
                    {
                        cnt++;
                    }
                }
            }

            Console.WriteLine(maxLen);
            Console.WriteLine(cnt);
        }
    }
}
