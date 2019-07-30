using System;
namespace Movie_List
{
    public static class MovieValidator
    {
        // return true if the string is not null or empty 
       public static bool Validator(string input)
        {
            return !string.IsNullOrEmpty(input);
        }
    }
}
