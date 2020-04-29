namespace ArdalisRating.Refactoring
{
    public interface IRaterFactory
    {
        Rater Create(Policy policy);
    }
}