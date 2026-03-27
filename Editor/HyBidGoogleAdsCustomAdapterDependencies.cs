#if UNITY_EDITOR
using UnityEditor;
using UnityEngine;

[InitializeOnLoad]
public static class HyBidGoogleAdsCustomAdapterDependencies
{
    static HyBidGoogleAdsCustomAdapterDependencies()
    {
        Debug.Log("[HyBidGoogleAdsCustomAdapter] Dependencies registered with EDM4U.");
    }
}
#endif