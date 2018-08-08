using System;

namespace LotteryService
{
    public class LotterySorter : ILotterySorter
    {
        public int[] NumSorter(int[] lotteryNums)
        {
            int temp;
            int swaps = 1;
            int lotteryNumsLength = lotteryNums.Length;

            while (swaps != 0)
            {
                swaps = 0;
                for (var i = 0; i < lotteryNumsLength - 1; i++)
                {
                    if (lotteryNums[i] > lotteryNums[i + 1])
                    {
                        temp = lotteryNums[i];
                        lotteryNums[i] = lotteryNums[i + 1];
                        lotteryNums[i + 1] = temp;
                        swaps++;
                    }
                }
            }

            return lotteryNums;
        }

        public string LetterSorter(string sentence)
        {
            var sentenceArr = sentence.ToLower().ToCharArray();
            var sentenceLength = sentenceArr.Length;
            char temp;
            var swaps = 0;

            for (var i = 0; i < sentenceLength; i++)
            {
                for (var j = 0; j < sentenceLength - 1; j++)
                {
                    if (sentenceArr[j] > sentenceArr[j + 1])
                    {
                        temp = sentenceArr[j];
                        sentenceArr[j] = sentenceArr[j + 1];
                        sentenceArr[j + 1] = temp;
                        swaps++;
                    }
                }

                if (swaps == 0)
                    break;
            }

            return new string(sentenceArr).Trim(new Char[] { ' ', '!', '?', '.', ',' });
        }
    }
}