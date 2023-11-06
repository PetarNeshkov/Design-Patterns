// Intent: Lets you define a family of algorithms, put each of them into a
// separate class, and make their objects interchangeable.

using Greeter.Types;

Greet();

return;

static void Greet()
{
    SimpleThreadSafetyGreeter.Instance.Greet();
    LocklessFullyLazyGreeter.Instance.Greet();
    LocklessGreeter.Instance.Greet();
    SimpleGreeter.Instance.Greet();
    DotNetLazyGreeter.Instance.Greet();
    DoubleCheckGreeter.Instance.Greet();
}

