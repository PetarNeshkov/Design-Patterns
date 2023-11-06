using Greeter.Types.Common;

namespace Greeter.Types;

/// <summary>
/// This implementation is thread-safe.
/// The thread takes out a lock on a shared object, and then checks whether
/// or not the instance has been created before retrieving the instance.
/// Unfortunately, performance suffers as a lock is acquired every time the instance is requested.
/// </summary>
public class SimpleThreadSafetyGreeter : BaseGreeter
{
    private static readonly object Padlock = new();

    private static SimpleThreadSafetyGreeter? instance;

    private SimpleThreadSafetyGreeter()
    {
    }

    public static SimpleThreadSafetyGreeter Instance
    {
        get
        {
            lock (Padlock)
            {
                if (instance == null)
                {
                    instance = new SimpleThreadSafetyGreeter();
                }

                return instance;
            }
        }
    }
}