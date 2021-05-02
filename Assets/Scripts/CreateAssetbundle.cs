using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class CreateAssetbundle : Editor
{
    [MenuItem("Assets/Build AssetBundle")]
    static void BuildAssetBundle()
    {
        BuildPipeline.BuildAssetBundles(@"C:\Users\HeisenBerg\Desktop\AssetBundle",BuildAssetBundleOptions.ChunkBasedCompression,BuildTarget.StandaloneWindows64);
    }
}
