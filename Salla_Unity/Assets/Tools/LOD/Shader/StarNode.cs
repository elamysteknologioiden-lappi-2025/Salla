/*using System.Reflection;
using UnityEditor.ShaderGraph;
using UnityEngine;

[Title("Procedural", "Shape", "Star")]
public class StarNode : CodeFunctionNode {
    public override bool hasPreview { get { return true; } }

    public StarNode() {
        name = "pLAB_LOD";
    }

    public override string documentationURL {
        get { return "https://github.com/andydbc/shadergraph-custom-nodes"; }
    }

    protected override MethodInfo GetFunctionToConvert() {
        return GetType().GetMethod("StarFunction", BindingFlags.Static | BindingFlags.NonPublic);
    }

    static string StarFunction(
        [Slot(3, Binding.None)] out Vector1 Out) {
        return @"
{ 
//#ifdef LOD_FADE_CROSSFADE
            Out =  unity_LODFade.x;
//#else
//            Out =  1;
//#endif

}";
    }
}*/