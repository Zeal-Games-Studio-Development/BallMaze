using UnityEngine;

namespace ZealMVC.Runtime.Utils
{
    public static class GameObjectExtension
    {
        public static bool IsLayerOf(this GameObject gameObject, LayerMask mask)
        {
            return (mask.value & (1 << gameObject.layer)) != 0;
        }

        public static bool IsLayerOf(this GameObject gObj, int Layer)
        {
            return gObj.layer == Layer;
        }
    }
}
