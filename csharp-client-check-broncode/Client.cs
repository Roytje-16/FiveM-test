using System;
using CitizenFX.Core;
using CitizenFX.Core.Native;
public class ClientCheck : BaseScript
{
    public ClientCheck()
    {
        Debug.WriteLine("[CSHARP-CHECK] C# constructor uitgevoerd");
        TriggerServerEvent("csharpcheck:loaded");
        API.RegisterCommand("+csharpcheck", new Action<int, System.Collections.Generic.List<object>, string>((source, args, raw) =>
        {
            Debug.WriteLine("[CSHARP-CHECK] F9 werkt");
            TriggerServerEvent("csharpcheck:pressed");
        }), false);
        API.RegisterCommand("-csharpcheck", new Action<int, System.Collections.Generic.List<object>, string>((source, args, raw) => { }), false);
        API.RegisterKeyMapping("+csharpcheck", "C# Client Check", "keyboard", "F9");
    }
}
