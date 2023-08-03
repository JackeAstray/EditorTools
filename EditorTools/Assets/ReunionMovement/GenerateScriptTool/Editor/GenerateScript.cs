using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using UnityEditor;
using UnityEngine;

namespace GameLogic.EditorTools
{
    /// <summary>
    /// 生成脚本
    /// </summary>
    public class GenerateScript : EditorWindow
    {
        // txt存放路径
        static string txtOpenPath = "Assets/ReunionMovement/GenerateScriptTool/Editor/Resources/Txt/";
        // 脚本输出路径
        static string scriptOutPutPath = "Assets/Scripts/AutoScripts/";
        // 类名
        string className = "ClassName"; 
        // 文件路径
        string filePath { get; set; }

        // 脚本名称
        string scriptName { get; set; }
        // 预制体名称
        string prefabsName { get; set; }
        // 场景名称
        string sceneName { get; set; }
        // 目标名称
        string targetName { get; set; }

        [MenuItem("工具箱/脚本生成工具", false, 4)]
        public static void ShowWindow()
        {
            //弹出编辑器
            GetWindow(typeof(GenerateScript), true, "生成新脚本", true);
        }

        void OnGUI()
        {
            //// 文本
            GUILayout.Label("");
            // 编辑类名和场景名
            className = EditorGUILayout.TextField("输入类名：", className);
            scriptOutPutPath = EditorGUILayout.TextField("脚本输出路径：", scriptOutPutPath);

            GUILayout.Space(10);

            if (GUILayout.Button("第一步 选择模板"))
            {
                filePath = EditorUtility.OpenFilePanel("选择模板", txtOpenPath, "txt");
            }

            if (GUILayout.Button("第二步 创建脚本"))
            {
                //按下按钮后执行的方法
                CreateScript(filePath);
            }
        }

        /// <summary>
        /// 创建脚本
        /// </summary>
        public async void CreateScript(string path)
        {
            scriptName = className;
            await CreateScript(path, scriptName);
            AssetDatabase.Refresh();
        }

        /// <summary>
        /// 创建脚本
        /// </summary>
        /// <param name="path"></param>
        /// <param name="name"></param>
        /// <returns></returns>
        public async Task CreateScript(string path, string name)
        {
            //等待编译结束
            if (EditorApplication.isCompiling)
            {
                EditorUtility.DisplayDialog("警告", "等待编译结束。", "OK");
                return;
            }

            string tempStr = "";
            //查看文件否存在
            if (File.Exists(path))
            {
                FileStream fs = new FileStream(path, FileMode.Open);
                StreamReader sr = new StreamReader(fs);
                tempStr = sr.ReadToEnd();
                sr.Close();
                if (fs != null)
                {
                    fs.Close();
                }
            }

            string str = tempStr;
            str = str.Replace("{_0_}", name);

            var dataName = scriptOutPutPath + name + ".cs";
            await Tools.SaveFile(dataName, str);

            AssetDatabase.Refresh();
        }
    }
}