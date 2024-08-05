using UnityEngine;
using UnityEngine.UI;

namespace ZealMVC.Runtime.Utils
{
    public static class GraphicHelper
    {
        public static void ChangeAlpha <T> (this T graphic, float alpha) where T : Graphic
        {
            var color = graphic.color;
            color.a = alpha;
            graphic.color = color;
        }

        public static void ChangeScale (this Transform transform, float scale) 
        {
            transform.localScale = new Vector3 (scale, scale, scale);
        }
    }
}
