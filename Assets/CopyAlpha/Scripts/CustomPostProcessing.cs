using System;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.Rendering.Universal;
using UnityEngine.Serialization;

[Serializable, VolumeComponentMenu("Custom-PostProcess")]
public class CustomPostProcessing : VolumeComponent, IPostProcessComponent
{
    public RenderPassSettingParameter renderPassSetting = new RenderPassSettingParameter();
    public bool IsActive() => renderPassSetting.overrideState;
    public bool IsTileCompatible() => false;

    [Serializable]
    public class RenderPassSetting
    {
        public RenderPassEvent passEvent;
        public RenderTexture targetTexture;
        public Material postProcessMat;
    }

    [Serializable]
    public class RenderPassSettingParameter : VolumeParameter<RenderPassSetting>
    {
    }
}