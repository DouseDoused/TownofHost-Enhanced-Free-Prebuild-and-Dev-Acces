using UnityEngine;

namespace TOHE;

public static class DebugModeManager
{
    public static bool AmDebugger { get; private set; } = true;

    public static bool IsDebugMode => AmDebugger && Main.EnableDebugMode.Value;

    public static void Auth(HashAuth auth, string input)
    {
        AmDebugger = AmDebugger || auth.CheckString(input);
    }

}
