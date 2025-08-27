/******************************************************************************
 * Filename    = GradeCalculatorUnitTests.cs
 *
 * Author      = Vaibhav Yadav
 *
 * Product     = SoftwareDesignPatterns
 * 
 * Project     = UnitTests
 *
 * Description = Unit tests for the grade calculator.
 *****************************************************************************/

using Microsoft.VisualStudio.TestTools.UnitTesting;
using StudentGradeCalc;

namespace UnitTests;

/// <summary>
/// Unit tests for the grade calculator.
/// </summary>
[TestClass]
public class GradeCalculatorUnitTests
{
    /// <summary>
    /// Tests average calculation with empty grades.
    /// </summary>
    [TestMethod]
    public void TestAverageWithEmptyGrades()
    {
        GradeCalculator calculator = new(Array.Empty<double>());
        Assert.AreEqual(0, calculator.CalculateAverage());
    }

    /// <summary>
    /// Tests average calculation with a single grade.
    /// </summary>
    [TestMethod]
    public void TestAverageWithSingleGrade()
    {
        GradeCalculator calculator = new(new double[] { 85 });
        Assert.AreEqual(85, calculator.CalculateAverage());
    }

    /// <summary>
    /// Tests average calculation with multiple grades.
    /// </summary>
    [TestMethod]
    public void TestAverageWithMultipleGrades()
    {
        GradeCalculator calculator = new(new double[] { 80, 90, 100 });
        Assert.AreEqual(90, calculator.CalculateAverage());
    }

    /// <summary>
    /// Tests average calculation with decimal grades.
    /// </summary>
    [TestMethod]
    public void TestAverageWithDecimalGrades()
    {
        GradeCalculator calculator = new(new double[] { 80.5, 90.5 });
        Assert.AreEqual(85.5, calculator.CalculateAverage(), 0.0001);
    }

    /// <summary>
    /// Tests average calculation with negative grades (no validation, just computation).
    /// </summary>
    [TestMethod]
    public void TestAverageWithNegativeGrades()
    {
        GradeCalculator calculator = new(new double[] { -10, 10 });
        Assert.AreEqual(0, calculator.CalculateAverage());
    }
}
