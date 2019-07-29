using System;
namespace Movie_List
{
    public class Movie
    {
        // A field is a name of a variable that should only be accesed by the program and not the user
        // A proprty is the name of a variable that can be accessed by the user
        // These are differnt so that the user can only access one instance of that variable
        // thus giving the program a layer of safety so the user is not acessing the
        // variable name that is changed and used in methods that are only accessed by the program.
        public string Title { get; set; }
        public string Category { get; set; }
       
        public Movie(string title, string category)
        {
            Title = title;
            Category = category;
        }
    }
}
