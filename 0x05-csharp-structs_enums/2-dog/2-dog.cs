using System;

enum Rating
{
    Good,
    Great,
    Excellent
}
struct Dog
{
    public Dog (string Name, float Age, string Owner, Rating Rating)
    {
        rating = Rating;
        name = Name;
        age = Age;
        owner = Owner;
    }
    public string name;
    public float age;
    public string owner;
    public Rating rating;
} 