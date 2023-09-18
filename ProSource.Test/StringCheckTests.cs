using NUnit.Framework;
using ProSource.Exam;

namespace ProSource.Test
{
    public class Tests
    {
        [TestCase("<>")]
        [TestCase("\"\"")]
        [TestCase("<abc...xyz>")]
        [TestCase("<<><>>")]
        [TestCase("<THIS><IS><CORRECT>")]
        [TestCase("<MAKE><<SOME><GROUPING>>")]
        public void TestIfIsEnclosedByAngleBracketsPass(string s)
        {            
            Assert.True(StringCheck.IsEnclosedByAngleBrackets(s));
        }

        [TestCase("><")]
        [TestCase("<<>")]
        [TestCase("<ignored...but...unclosed")]
        [TestCase("<><><><><><><<>><")]
        [TestCase("<THIS><IS><WRONG>>")]
        [TestCase("<DONT><<CLOSE><GROUPING>")]
        public void TestIfIsEnclosedByAngleBracketsFail(string s)
        {
            Assert.False(StringCheck.IsEnclosedByAngleBrackets(s));
        }
    }
}