// Copyright (c) Gaurav Aroraa
// Licensed under the MIT License. See License.txt in the project root for license information.

using NUnit.Framework;

/*
A field of N x M squares is represented by N lines of
exactly M characters each. The character '*' represents
a mine and the character '.' represents no-mine.

Example input (a 4 x 3 mine-field of 12 squares, 2 of
which are mines)

4 3
*...
..*.
....

Your task is to write a program to accept this input and
produce as output a hint-field of identical dimensions
where each square is a * for a mine or the number of
adjacent mine-squares if the square does not contain a mine.

Example output (for the above input)
*211
12*1
0111
*/
namespace TDD_Katas_NETCore.MineFields
{
    [TestFixture]
    [Category("MineFields NET Core")]
    internal class TestMineFields
    {
        [Test]
        public void Build_field_size_of_one_by_one_and_one_mine()
        {
            var fields = new MineFields();

            fields.Create(1, 1);
            fields.Mine(0, 0);

            Assert.That(fields.GetHint(0, 0), Is.EqualTo(-1));
        }

        [Test]
        public void Build_field_size_of_one_by_one_and_zero_mine()
        {
            var fields = new MineFields();

            fields.Create(1, 1);

            Assert.That(fields.GetHint(0, 0), Is.EqualTo(0));
        }

        [Test]
        [TestCase(0, 0, Constants.Mine)]
        [TestCase(1, 0, Constants.Mine)]
        [TestCase(2, 0, 1)]
        [TestCase(0, 1, 3)]
        [TestCase(1, 1, 3)]
        [TestCase(2, 1, 2)]
        [TestCase(0, 2, 1)]
        [TestCase(1, 2, -1)]
        [TestCase(2, 2, 1)]
        public void Build_three_by_three_field_and_three_of_mine(int xPos, int yPos, int expect)
        {
            var fields = new MineFields();

            fields.Create(3, 3);
            fields.Mine(0, 0);
            fields.Mine(1, 0);
            fields.Mine(1, 2);

            Assert.That(fields.GetHint(xPos, yPos), Is.EqualTo(expect));
        }

        [Test]
        [TestCase(0, 0, -1)]
        [TestCase(1, 0, -1)]
        [TestCase(2, 0, 1)]
        [TestCase(0, 1, 2)]
        [TestCase(1, 1, 2)]
        [TestCase(2, 1, 1)]
        [TestCase(0, 2, 0)]
        [TestCase(1, 2, 0)]
        [TestCase(2, 2, 0)]
        public void Build_three_by_three_field_and_two_of_mine(int xPos, int yPos, int expect)
        {
            var fields = new MineFields();

            fields.Create(3, 3);
            fields.Mine(0, 0);
            fields.Mine(1, 0);

            Assert.That(fields.GetHint(xPos, yPos), Is.EqualTo(expect));
        }

        [Test]
        [TestCase(0, 0, Constants.Mine)]
        [TestCase(1, 0, Constants.Mine)]
        [TestCase(0, 1, Constants.Mine)]
        [TestCase(1, 1, Constants.Mine)]
        public void Build_two_by_two_field_and_four_of_mine(int xPos, int yPos, int expect)
        {
            var fields = new MineFields();

            fields.Create(2, 2);
            fields.Mine(0, 0);
            fields.Mine(1, 0);
            fields.Mine(0, 1);
            fields.Mine(1, 1);

            Assert.That(fields.GetHint(xPos, yPos), Is.EqualTo(expect));
        }

        [Test]
        [TestCase(0, 0, 1)]
        [TestCase(1, 0, 1)]
        [TestCase(0, 1, Constants.Mine)]
        [TestCase(1, 1, 1)]
        public void Build_two_by_two_field_and_one_of_mine_bottomleftcorner(int xPos, int yPos, int expect)
        {
            var fields = new MineFields();

            fields.Create(2, 2);
            fields.Mine(0, 1);

            Assert.That(fields.GetHint(xPos, yPos), Is.EqualTo(expect));
        }

        [Test]
        [TestCase(0, 0, 1)]
        [TestCase(1, 0, 1)]
        [TestCase(0, 1, 1)]
        [TestCase(1, 1, Constants.Mine)]
        public void Build_two_by_two_field_and_one_of_mine_bottomrightcorner(int xPos, int yPos, int expect)
        {
            var fields = new MineFields();

            fields.Create(2, 2);
            fields.Mine(1, 1);

            Assert.That(fields.GetHint(xPos, yPos), Is.EqualTo(expect));
        }

        [Test]
        [TestCase(0, 0, -1)]
        [TestCase(1, 0, 1)]
        [TestCase(0, 1, 1)]
        [TestCase(1, 1, 1)]
        public void Build_two_by_two_field_and_one_of_mine_topleftcorner(int xPos, int yPos, int expect)
        {
            var fields = new MineFields();

            fields.Create(2, 2);
            fields.Mine(0, 0);

            Assert.That(fields.GetHint(xPos, yPos), Is.EqualTo(expect));
        }

        [Test]
        [TestCase(0, 0, 1)]
        [TestCase(1, 0, Constants.Mine)]
        [TestCase(0, 1, 1)]
        [TestCase(1, 1, 1)]
        public void Build_two_by_two_field_and_one_of_mine_toprightcorner(int xPos, int yPos, int expect)
        {
            var fields = new MineFields();

            fields.Create(2, 2);
            fields.Mine(1, 0);

            Assert.That(fields.GetHint(xPos, yPos), Is.EqualTo(expect));
        }

        [Test]
        [TestCase(0, 0, Constants.Mine)]
        [TestCase(1, 0, Constants.Mine)]
        [TestCase(0, 1, Constants.Mine)]
        [TestCase(1, 1, 3)]
        public void Build_two_by_two_field_and_three_of_mine(int xPos, int yPos, int expect)
        {
            var fields = new MineFields();

            fields.Create(2, 2);
            fields.Mine(0, 0);
            fields.Mine(1, 0);
            fields.Mine(0, 1);

            Assert.That(fields.GetHint(xPos, yPos), Is.EqualTo(expect));
        }

        [Test]
        [TestCase(0, 0, Constants.Mine)]
        [TestCase(1, 0, Constants.Mine)]
        [TestCase(0, 1, 2)]
        [TestCase(1, 1, 2)]
        public void Build_two_by_two_field_and_two_of_mine(int xPos, int yPos, int expect)
        {
            var fields = new MineFields();

            fields.Create(2, 2);
            fields.Mine(0, 0);
            fields.Mine(1, 0);

            Assert.That(fields.GetHint(xPos, yPos), Is.EqualTo(expect));
        }
    }
}