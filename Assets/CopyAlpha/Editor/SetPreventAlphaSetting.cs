using UnityEditor;

[InitializeOnLoad]
public class SetPreventAlphaSetting
{
    //use FP16 HDR Mode in URP
    static SetPreventAlphaSetting()
    {
        PlayerSettings.preserveFramebufferAlpha = true;
    }
}
