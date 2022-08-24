namespace Demo.Common
{
    public interface IService
    {
        string ValuePassedIn { get; set; }
        string DoSomeWork();
        string FakeMethodHere();
    }
}