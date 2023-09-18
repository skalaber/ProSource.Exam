namespace ProSource.Exam
{
    public static class StringCheck
    {
        public static bool IsEnclosedByAngleBrackets(string s)
        {
            int[] openingIndexes = GetIndexes(s, '<');
            int[] closingIndexes = GetIndexes(s, '>');

            if (openingIndexes.Length != closingIndexes.Length)
                return false;

            for(int i = 0; i < openingIndexes.Length; i++)
                if (openingIndexes[i] >= closingIndexes[i])
                    return false;

            return true;
        }

        private static int[] GetIndexes(string s, char c)
        {
            return Enumerable.Range(0, s.Length)
             .Where(i => s[i] == c)
             .ToArray();
        }
    }
}