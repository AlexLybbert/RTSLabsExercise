using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RTSLabsExercise
{
    public class StringRotator
    {
        //Long-winded version
        public static string stringRotation(string original, int rotationAmount)
        {
            int length = original.Length;
            rotationAmount = rotationAmount % length; // ensure rotationAmount is within the range of the string length
            if (rotationAmount == 0) return original; // no rotation needed
            return original.Substring(length - rotationAmount) + original.Substring(0, length - rotationAmount);
        }

        //Concise version
        public static string stringRotationConcise(string original, int rotationAmount)
        {
            // Calculate the effective rotation amount within the range of the string length
            rotationAmount %= original.Length;

            // If no rotation is needed, return the original string
            if (rotationAmount == 0)
            {
                return original;
            }

            // Select the rightmost substring of length 'rotationAmount' and concatenate it
            // with the leftmost substring of length 'original.Length - rotationAmount'
            // This creates the rotated string with the overflow characters at the beginning
            return original[^rotationAmount..] + original[..^rotationAmount];
        }

    }
}
