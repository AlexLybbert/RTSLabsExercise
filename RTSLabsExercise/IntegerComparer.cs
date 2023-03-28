namespace RTSLabsExercise
{
    public class IntegerComparer
    {
        //The longwinded version
        public Dictionary<string, int> aboveBelow(List<int> numbers, int comparison)
        {
            //Initial setup
            Dictionary<string, int> result = new Dictionary<string, int>();
            int aboveCount = 0;
            int belowCount = 0;

            //Loop through numbers in the list
            foreach (int number in numbers)
            {
                //Compare number against comparison value
                if (number > comparison)
                {
                    //Increment the count of numbers above the comparison value
                    aboveCount++;
                }
                else if (number < comparison)
                {
                    //Increment the count of numbers below the comparison value
                    belowCount++;
                }
            }

            //Add results to dictionary
            result.Add("above", aboveCount);
            result.Add("below", belowCount);

            return result;
        }

        //Semi-concise version
        public Dictionary<string, int> aboveBelowSemiConcise(List<int> numbers, int comparison)
        {
            //Initial setup
            var counts = new Dictionary<string, int>() { { "above", 0 }, { "below", 0 } };

            //Loop through numbers in the list
            foreach (var number in numbers)
            {
                //Compare number against comparison value
                if (number > comparison)
                {
                    //Increment the count of numbers above the comparison value
                    counts["above"]++;
                }
                else if (number < comparison)
                {
                    //Increment the count of numbers below the comparison value
                    counts["below"]++;
                }
            }

            return counts;
        }

        //Concise version using LINQ
        public Dictionary<string, int> aboveBelowStreamlined(List<int> numbers, int comparison)
        {
            //Create dictionary with the counts of the numbers above and below the comparison value
            return new Dictionary<string, int>
            {
                ["above"] = numbers.Count(x => x > comparison),
                ["below"] = numbers.Count(x => x < comparison)
            };
        }
    }


}