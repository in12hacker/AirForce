﻿using UnityEditor;
using UnityEngine;

namespace AirForce.Editor
{
    public static class ProjectSaver
    {
        /// <summary>
        /// 存储可序列化的资源。
        /// </summary>
        /// <remarks>等同于执行 Unity 菜单 File/Save Project。</remarks>
        [MenuItem("Air Force/Save Assets &s")]
        public static void SaveAssets()
        {
#if UNITY_5_3 || UNITY_5_4
            EditorApplication.SaveAssets();
#else
            AssetDatabase.SaveAssets();
#endif
            Debug.Log("You have saved the serializable assets in the project.");
        }
    }
}
