﻿using UnityEngine;

namespace XenoUtilities
{
    public static partial class XenoUtilities
    {
        public static Vector2 Vec2xy(this Vector3 vector)
        {
            return new Vector2(vector.x, vector.y);
        }
        
        public static Vector2 Vec2xz(this Vector3 vector)
        {
            return new Vector2(vector.x, vector.z);
        }
        
        public static Vector2 Vec2yz(this Vector3 vector)
        {
            return new Vector2(vector.y, vector.z);
        }
        
        public static Vector3 Vec3xy(this Vector3 vector)
        {
            return new Vector3(vector.x, vector.y, 0);
        }
        
        public static Vector3 Vec3xz(this Vector3 vector)
        {
            return new Vector3(vector.x, 0, vector.z);
        }
        
        public static Vector3 Vec3yz(this Vector3 vector)
        {
            return new Vector3(0, vector.y, vector.z);
        }

    }
}