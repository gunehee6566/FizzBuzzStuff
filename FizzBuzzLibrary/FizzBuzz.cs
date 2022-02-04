namespace FizzBuzzLibrary;
public class FizzBuzz
{

    public string GetResult(int nmbr)
    {

        if(nmbr > 1000 || nmbr <=0) throw new Exception();

        string result = "";

        for (int ndx=1; ndx<nmbr+1; ndx++) {
        if (ndx % 3 == 0 && ndx % 5 ==0)
            result += "Fizz-Buzz ";
        else if (ndx % 5 ==0 )
            result += "Buzz ";
        else if (ndx % 3 ==0 )
            result += "Fizz ";                    
        else
            result += ndx.ToString() + " ";
    }

        return result;
    }

}
