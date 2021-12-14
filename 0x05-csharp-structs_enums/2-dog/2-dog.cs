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
    public string name {get; init;}
    public float age {get; init;}
    public string owner {get; init;}
    public Rating rating {get; init;}
} 