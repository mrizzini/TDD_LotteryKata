namespace LotteryService
{
    public interface ILotterySorter
    {
         int[] NumSorter(int[] lotteryNums);

         string LetterSorter(string sentence);

    }
}