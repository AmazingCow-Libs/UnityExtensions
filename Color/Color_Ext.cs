//COWTODO(n2omatt): Add License Header
//COWTODO(n2omatt): Format code.

using UnityEngine;


namespace AmazingCow.UnityExtensions
{
    public static class Color_Ext
    {
        public static uint GetPackedRGBValue(this Color color)
        {
            return (((uint)(255 * color.r) & 0xff) << 16) +
                   (((uint)(255 * color.g) & 0xff) << 8) +
                   (((uint)(255 * color.b) & 0xff) << 0);
        }

    }//class Color_Ext
}//namespace AmazingCow.UnityExtensions