using System;
using System.Collections.Generic;

namespace LotteryService
{
    public class Class1
    {
        private readonly ILotterySorter _lotterySorter;

        public Class1(ILotterySorter lotterSorter)
        {
            _lotterySorter = lotterSorter;
        }

        public int[] SortNumbers(int[] lotteryNums)
        {
            if (lotteryNums.Length < 2)
            {
                return lotteryNums;
            }

            return _lotterySorter.NumSorter(lotteryNums);
            
            // int temp;
            // int swaps = 0;
            // int lotteryNumsLength = lotteryNums.Length;
            // // bool isSorted = false;



            // // while (!isSorted)
            // // {
            // //     swaps = 0;

            // //     for (int i = 0; i < lotteryNums.Length - 1; i++)
            // //     {
                    
            // //         if (lotteryNums[i] > lotteryNums[i + 1])
            // //         {
            // //             temp = lotteryNums[i];
            // //             lotteryNums[i] = lotteryNums[i + 1];
            // //             lotteryNums[i + 1] = temp;
            // //             swaps++;
            // //         }

            // //         if (i == lotteryNums.Length - 2 && swaps == 0)
            // //             isSorted = true;
            // //     }

            // // }

            // for (int i = 0; i < lotteryNumsLength; i++)
            // {
            //     for (int j = 0; j < lotteryNumsLength - 1; j++)
            //     {
            //         if (lotteryNums[j] > lotteryNums[j + 1])
            //         {
            //             temp = lotteryNums[j];
            //             lotteryNums[j] = lotteryNums[j + 1];
            //             lotteryNums[j + 1] = temp;
            //             swaps++;
            //         }
            //     }

            //     if (swaps == 0)
            //     {
            //         break;
            //     }
            // }

            // return lotteryNums;
        }

        public string SortSentence(string sentence)
        {
            
            if (sentence.Length < 2)
                return sentence;

            return _lotterySorter.LetterSorter(sentence);

            // var sentenceArr = sentence.ToLower().ToCharArray();
            // var sentenceLength = sentenceArr.Length;
            // char temp;
            // var swaps = 0;


            // for (var i = 0; i < sentenceLength; i++)
            // {
            //     // swaps = 0;
            //     for (var j = 0; j < sentenceLength - 1; j++)
            //     {
            //         if (sentenceArr[j] > sentenceArr[j + 1])
            //         {
            //             temp = sentenceArr[j];
            //             sentenceArr[j] = sentenceArr[j + 1];
            //             sentenceArr[j + 1] = temp;
            //             swaps++;
            //         }
            //     }

            //     if (swaps == 0)
            //         break;
            // }

            // return new string(sentenceArr).Trim(new Char[] { ' ', '!', '?', '.', ',' });
        }

    }

    public class Class2
    {
        public int CharCounter(string sentence, char letter)
        {
            // return 0;
            var counter = 0;

            foreach (var character in sentence)
            {
                if (character == letter)
                    counter++;
            }

            return counter;
        }
    }
}
