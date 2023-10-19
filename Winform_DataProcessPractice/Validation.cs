using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Winform_DataProcessPractice
{
    public static class Validation
    {
        /// <summary>
        /// Validates whether the data is empty or contains only whitespace.
        /// </summary>
        /// <param name="value">The data to be checked.</param>
        /// <returns>True if the data is not empty, otherwise false.</returns>
        /// <exception cref="ArgumentException">Thrown if the data is empty, with the message "Data is empty...".</exception>
        public static bool isFilled(string value)
        {
            if (!string.IsNullOrWhiteSpace(value)) return true;
            throw new ArgumentException("Data is empty...");
        }

        /// <summary>
        /// Validates whether the data is a positive value (excluding 0).
        /// </summary>
        /// <param name="value">The data to be checked.</param>
        /// <returns>True if the data is positive, otherwise false.</returns>
        /// <exception cref="ArgumentException">Thrown if the data is not positive (0 or negative), with the message "Data must be greater than zero".</exception>
        public static bool isPositive(double value)
        {
            if (value > 0) return true;
            throw new ArgumentException("Data must be greater than zero");
        }

    }
}
