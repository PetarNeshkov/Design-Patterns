using StateLibrary.PackageExample.States;
using StateLibrary.PackageExample.States.Common;

namespace StateLibrary.PackageExample
{
    public class Package
    {
        private PackageState state = new OrderedState();

        public void Proceed() => state.Proceed(this);

        public void Revert() => state.Revert(this);

        public void PrintStatus() => state.PrintStatus();

        public void ChangeState(PackageState state) => this.state = state;
    }
}