# This is to script to add a user on the system and place him in the administrator group

# In linux


```bash
sudo apt install mono-complete
mcs -r:System.Configuration.Install.dll -r:/usr/share/powershell-empire/empire/server/csharp/Covenant/Data/AssemblyReferences/net40/System.Management.Automation.dll -r:/usr/lib/mono/4.7.2-api/Facades/System.Runtime.dll exe.cs
```

# In Windows

```bash
c:\Windows\Microsoft.NET\Framework\v4.0.30319\csc.exe /reference:"C:\windows\assembly\GAC_MSIL\System.Management.Automation\1.0.0.0__31bf3856ad364e35\System.Management.Automation.dll" C:\users\dhanush\Desktop\exe.cs
```
