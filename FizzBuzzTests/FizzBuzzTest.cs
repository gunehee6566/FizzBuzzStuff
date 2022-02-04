using Xunit;
using FizzBuzzLibrary;
using System;

namespace FizzBuzzTests;


public class FizzBuzzTest
{
    [Fact]
    public void Given2Output12()
    {
        FizzBuzz fb = new FizzBuzz();
        Assert.Equal("1 2 ", fb.GetResult(2));
    }

    [Fact]
    public void Given3Result12fizz()
    {
        FizzBuzz fb = new FizzBuzz();
        Assert.Equal("1 2 Fizz ", fb.GetResult(3));
    }

    [Fact]
    public void Given4Result12fizz()
    {
        FizzBuzz fb = new FizzBuzz();
        Assert.Equal("1 2 Fizz 4 ", fb.GetResult(4));
    }

    [Fact]
    public void Given5Result12fizz4buzz()
    {
        FizzBuzz fb = new FizzBuzz();
        string expected = "1 2 Fizz 4 Buzz ";
        string actual = fb.GetResult(5);
        Assert.Equal(expected, actual);
    }

    [Fact]
    public void Given15Result12fizz4buzzfizz78fizzbuzz11fizzfizz1314fizzbuzz()
    {
        FizzBuzz fb = new FizzBuzz();
        Assert.Equal("1 2 Fizz 4 Buzz Fizz 7 8 Fizz Buzz 11 Fizz 13 14 FizzBuzz ", fb.GetResult(15));
    }

    [Fact]
    public void GivenMoreThan1000ThrowException()
    {
        FizzBuzz fb = new FizzBuzz();
        Action act = () => fb.GetResult(1001);
        Assert.Throws<Exception>(act);
    }

    [Fact]
    public void GivenLessThan1ThrowException()
    {
        FizzBuzz fb = new FizzBuzz();
        Action act = () => fb.GetResult(-1001);
        Assert.Throws<Exception>(act);
    }

}
