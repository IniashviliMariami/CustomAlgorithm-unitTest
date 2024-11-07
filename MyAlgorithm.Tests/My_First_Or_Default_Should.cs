
using CustomAlgorithm;
using System.Reflection;

namespace MyAlgorithm.Tests
{

    public class My_First_Or_Default_Should
    {
        [Fact]
        public void Find_First_Element()
        {

            List<int> testData = new() { 1, -2, 3 };

            var expected = -2;


            var actual = testData.MyFirstOrDefault(x => x < 0);


            Assert.Equal(expected, actual);

        }

        public void Find_Last_Element()
        {
            List<int> lastEllement = new() { 5, 10, 15, 20 };


            var actualLastElement = lastEllement.MyLastOrDefault(x => x > 15);
            Assert.Equal(20, actualLastElement);
        }


        public void My_Where_Element()
        {
            List<int> elenemts = new() { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            var expected = new List<int> { 6, 7, 8, 9 };
            var result = elenemts.MyWhere(x => x > 5);

            Assert.Equal(expected, result);
        }


        public void ForeachTets()
        {
            List<int> foreachTets = new() { 1, 2, 3, 4, 5, 6 };
            var result = foreachTets.MyForeach();

            Assert.Equal(3, foreachTets[2]);
        }
        public void My_Index_Of()
        {
            var numbers = new List<int> { 10, 20, 30, 40, 50 };


            int result = numbers.MyIndexOf(x => x == 30);

            Assert.Equal(2, result);
        }

        public void LastIndexTest()
        {
            var numbers = new List<int> { 10, 20, 30, 40, 30, 50 };

            var result = numbers.MyLastIndexOf(x => x == 30);

            Assert.Equal(4, result);


        }

        public void My_Select()
        {
            var numbers = new List<int> { 1, 2, 3 };

            var result = numbers.MySelect(n => n.ToString()).ToList();


            Assert.Equal(new List<string> { "1", "2", "3" }, result);
        }
        public void OrderBy()
        {
            List<int> numbers = new() { 3, 1, 5, 4, 1, 5 };

            var result = numbers.MyOrderBy((x, y) => x < y);
            Assert.Equal(new List<int> { 1, 1, 3, 4, 5, 5 }, result);
        }
        public void Sum_Test()
        {
            List<int> list = new() { 1, 4, 5 };



            var result = list.Sum(x => x);


            Assert.Equal(10, result);
        }

        public void My_Reverse()
        {
            List<int> list = new() { 1, 3, 5, 7, 9 };

            var result = list.MyReverse(x => x % 2 == 0);
            Assert.Empty(result);


        }

        public void My_Any()
        {
            List<int> list = new() { 1, 3, 5, 7, 9 };

            var result = list.MyAny(x => x % 3 == 0);
            Assert.True(result);
        }

        public void My_All()
        {
            List<int> list = new() { 1, 3, 5 };
            var result = list.MyAll(x => x % 2 == 0);

            Assert.False(result);
        }

        public void Max_test()
        {
            List<int> list = new() { 1, 4, 5 };

            Assert.Equal(5, list.MyMax());
        }

        public void My_Min()
        {
            List<int> list = new() { 1, 4, 5 };
            Assert.Equal(1, list.MyMin());

        }
    }
}
