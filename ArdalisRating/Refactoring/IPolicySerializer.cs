namespace ArdalisRating.Refactoring
{
    public interface IPolicySerializer
    {
        Policy GetPolicyFromJsonString(string jsonString);
    }
}