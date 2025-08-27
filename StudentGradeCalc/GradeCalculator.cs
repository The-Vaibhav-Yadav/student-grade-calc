/******************************************************************************
 * Filename    = GradeCalculator.cs
 *
 * Author      = Vaibhav Yadav
 *
 * Product     = SoftwareDesignPatterns
 * 
 * Project     = StudentGradeCalc
 *
 * Description = Computes the average of student grades, adhering to Single Responsibility Principle.
 *****************************************************************************/

namespace StudentGradeCalc;

/// <summary>
/// Calculates the average of a set of student grades.
/// </summary>
public class GradeCalculator
{
    private readonly double[] _grades;

    /// <summary>
    /// Creates an instance of the grade calculator.
    /// </summary>
    /// <param name="grades">The array of grades to compute the average for.</param>
    public GradeCalculator(double[] grades)
    {
        _grades = grades ?? Array.Empty<double>();
    }

    /// <summary>
    /// Calculates the average of the grades.
    /// </summary>
    /// <returns>The average grade, or 0 if no grades are provided.</returns>
    public double CalculateAverage()
    {
        if (_grades.Length == 0)
        {
            return 0;
        }

        double sum = 0;
        foreach (double grade in _grades)
        {
            sum += grade;
        }

        return sum / _grades.Length;
    }
}
