using UnityEngine;

namespace ZealMVC.Runtime.Utils
{
    public struct StringHelper
    {
        public static string RandomUsername()
        {
            var randNumber = Random.Range(100000, 199999);
            return $"User#{randNumber}";
        }
    }
}
