using LotteryService;
using NUnit.Framework;

namespace Tests
{
    public class Tests
    {
        ILotterySorter _lotterSorter = new LotterySorter();

        [Test]
        public void ReturnArray()
        {
            Class1 _testService = new Class1(_lotterSorter);
            int[] lotteryNums0 = new int[0];
            var output = _testService.SortNumbers(lotteryNums0);
            Assert.AreEqual(new int[0], output);
        }

        [Test]
        public void ReturnOneNumberSorted()
        {
            Class1 _testService = new Class1(_lotterSorter);
            int[] lotteryNums1 = new int[1];
            lotteryNums1[0] = 15;
            var output = _testService.SortNumbers(lotteryNums1);
            var expectedResult = new int[1] {15};
            Assert.AreEqual(expectedResult, output);
        }

        [Test]
        public void ReturnTwoNumbersSorted()
        {
            Class1 _testService = new Class1(_lotterSorter);
            int[] lotteryNums2 = new int[2];
            lotteryNums2[0] = 30;
            lotteryNums2[1] = 15;
            var output = _testService.SortNumbers(lotteryNums2);
            var expectedResult = new int[2] {15, 30};
            Assert.AreEqual(expectedResult, output);
        }

        [Test]
        public void ReturnThreeNumbersSorted()
        {
            Class1 _testService = new Class1(_lotterSorter);        
            int[] lotteryNums3 = new int[3];
            lotteryNums3[0] = 30;
            lotteryNums3[1] = 15;
            lotteryNums3[2] = 2;
            var output = _testService.SortNumbers(lotteryNums3);
            var expectedResult = new int[3] {2, 15, 30};
            Assert.AreEqual(expectedResult, output);
        }

        [Test]
        public void Return10NumbersSorted()
        {
            Class1 _testService = new Class1(_lotterSorter);
            int[] lotteryNums3 = new int[10];
            lotteryNums3[0] = 10;
            lotteryNums3[1] = 5;
            lotteryNums3[2] = 3;
            lotteryNums3[3] = 8;
            lotteryNums3[4] = 9;
            lotteryNums3[5] = 2;
            lotteryNums3[6] = 4;
            lotteryNums3[7] = 6;
            lotteryNums3[8] = 1;
            lotteryNums3[9] = 7;
            var output = _testService.SortNumbers(lotteryNums3);
            var expectedResult = new int[10] {1, 2, 3, 4, 5, 6, 7, 8, 9, 10};
            Assert.AreEqual(expectedResult, output);
        }



        [Test]
        public void ReturnString()
        {
            Class1 _testService = new Class1(_lotterSorter);
            string sentence = "a";
            var output = _testService.SortSentence(sentence);
            var expectedResult = "a";
            Assert.AreEqual(expectedResult, output);
        }

        [Test]
        public void ReturnTwoLettersSorted()
        {
            Class1 _testService = new Class1(_lotterSorter);
            string sentence = "ba";
            var output = _testService.SortSentence(sentence);
            var expectedResult = "ab";
            Assert.AreEqual(expectedResult, output);
        }

        [Test]
        public void ReturnThreeLettersSorted()
        {
            Class1 _testService = new Class1(_lotterSorter);
            string sentence = "cba";
            var output = _testService.SortSentence(sentence);
            var expectedResult = "abc";
            Assert.AreEqual(expectedResult, output);
        }

        [Test]
        public void ReturnFiveLettersSorted()
        {
            Class1 _testService = new Class1(_lotterSorter);
            string sentence = "crbzi";
            var output = _testService.SortSentence(sentence);
            var expectedResult = "bcirz";
            Assert.AreEqual(expectedResult, output);
        }

        [Test]
        public void ReturnMixedCaseLettersSorted()
        {
            Class1 _testService = new Class1(_lotterSorter);
            string sentence = "crBzIAAA";
            var output = _testService.SortSentence(sentence);
            var expectedResult = "aaabcirz";
            Assert.AreEqual(expectedResult, output);
        }

        [Test]
        public void ReturnMixedPunctuationLettersSorted()
        {
            Class1 _testService = new Class1(_lotterSorter);
            string sentence = "When not studying nuclear physics, Bambi likes to play beach volleyball.";
            var output = _testService.SortSentence(sentence);
            var expectedResult = "aaaaabbbbcccdeeeeeghhhiiiiklllllllmnnnnooopprsssstttuuvwyyyy";
            Assert.AreEqual(expectedResult, output);
        }

        [Test]
        public void ReturnLettersAndNonsenseSorted()
        {
            Class1 _testService = new Class1(_lotterSorter);
            string sentence = "!!!W...???.........a.....L....b.      f";
            var output = _testService.SortSentence(sentence);
            var expectedResult = "abflw";
            Assert.AreEqual(expectedResult, output);
        }
    }

    public class Tests2
    {
        [Test]
        public void ReturnNumOfTimesCharOccursInShortString()
        {
            Class2 _testService2 = new Class2();
            var input = "TDD is awesome!";
            var output = _testService2.CharCounter(input, 'e');
            var expectedResult = 2;
            Assert.AreEqual(expectedResult, output);
        }

        [Test]
        public void ReturnNumOfTimesCharOccursInLongString()
        {
            Class2 _testService2 = new Class2();
            var input1 = "Once is unique, twice is a coincidence, three times is a pattern.";
            var input2 = 'n';
            var output = _testService2.CharCounter(input1, input2);
            var expectedResult = 5;
            Assert.AreEqual(expectedResult, output);
        }

    }
}