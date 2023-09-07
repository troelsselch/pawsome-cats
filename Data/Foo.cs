using System.Security;

namespace PawsomeCats.Data;

[SecurityCritical]
public class Foo
{
    [SecuritySafeCritical] // Noncompliant
    public void Bar()
    {
    }
}