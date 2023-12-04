using System;
using ProxyLibrary.ProtectionProxyExample.Common;

namespace ProxyLibrary.ProtectionProxyExample;

public class SharedFolderProxy : ISharedFolder
{
    private readonly Employee employee;
    private readonly SharedFolder sharedFolder;
    
    public SharedFolderProxy(Employee employee, SharedFolder sharedFolder)
    {
        this.employee = employee;
        this.sharedFolder = sharedFolder;
    }
    
    public void Access()
    {
        if (employee.Role is Role.Manager or Role.CEO)
        {
            sharedFolder.Access();
            
            return;
        }

        Console.WriteLine($"The employee with the role '{employee.Role}' doesn't have access to the shared folder");
    }
}