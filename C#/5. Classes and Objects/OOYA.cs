using System;

namespace DatingProfile
{
    class Program
    {
        static void Main(string[] args)
        {
            Profile sam = new Profile("Sam Drakkila", 30, "New York", "USA", "he/him");

            sam.SetHobbies(new string[] { "listening to audiobooks and podcasts", "playing rec sports like bowling and kickball", "writing a speculative fiction novel", "reading advice columns" });

            Console.WriteLine(sam.ViewProfile());

        }
    }
}


class Profile
{
    // fields
    private string name;
    private int age;
    private string city;
    private string country;
    private string pronouns;
    private string[] hobbies;

    // constructor
    public Profile(string name, int age, string city, string country, string pronouns = "they/them")
    {
        this.name = name;
        this.age = age;
        this.city = city;
        this.country = country;
        this.pronouns = pronouns;
    }
    //methods
    public string ViewProfile()
    {

        string currentHobbies = " ";

        foreach (string hobby in hobbies)
        {
            currentHobbies += hobby + ",";
        }

        string bio = $"Name: {name}\n Age: {age}\n City: {city}\n Country: {country}\n Pronouns: {pronouns}\n Hobbies: {currentHobbies}";

        return bio;
    }

    public void SetHobbies(string[] hobbies)
    {
        this.hobbies = hobbies;
    }