using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace GameLogic
{
    public class StartApp : AppGame
    {
        protected override IList<CustommModuleInitialize> CreateModules()
        {
            var modules = base.CreateModules();

            modules.Add(TerminalModule.Instance);
            modules.Add(ResourcesModule.Instance);
            modules.Add(DatabaseModule.Instance);
            modules.Add(EventModule.Instance);
            modules.Add(LanguagesModule.Instance);
            modules.Add(SoundPoolModule.Instance);
            modules.Add(SoundModule.Instance);
            modules.Add(UIModule.Instance);
            modules.Add(SceneModule.Instance);
            modules.Add(ColorPaletteModule.Instance);

            return modules;
        }

        /// <summary>
        /// 在初始化模块之前，协同程序
        /// </summary>
        /// <returns></returns>
        public override IEnumerator OnBeforeInit()
        {
            Log.Debug("StartGame初始化前");

            ////到期销毁
            //DateTime minTime = Convert.ToDateTime("2023-8-25");
            //DateTime maxTime = Convert.ToDateTime("2023-9-10");
            //if (minTime > DateTime.Now || DateTime.Now > maxTime)
            //{
            //    Destroy(gameObject);
            //}

            yield return null;
        }

        /// <summary>
        /// 在初始化模块之后，协同路由
        /// </summary>
        /// <returns></returns>
        public override IEnumerator OnGameStart()
        {
            Log.Debug("StartGame初始化后");

            yield return null;

            //TerminalModule.Instance.terminalRequest.RegisterCommands();
            StartCoroutine(StartGame());
        }

        public IEnumerator StartGame()
        {
            //UIModule.Instance.OpenWindow("StartAppUIPlane");
            //SoundModule.Instance.PlayMusic(100001);
            yield return new WaitForSeconds(0f);
        }

        /// <summary>
        /// 在应用退出或者在编辑器里停止运行之前调用
        /// </summary>
        void OnApplicationQuit()
        {

        }
        /// <summary>
        /// 当程序获得或者失去焦点时
        /// </summary>
        /// <param name="focus">false失去焦点 true获得焦点</param>
        void OnApplicationFocus(bool focus)
        {

        }

        /// <summary>
        /// 当程序暂停
        /// </summary>
        /// <param name="focus">true暂停 false取消暂停</param>
        void OnApplicationPause(bool focus)
        {

        }

        /// <summary>
        /// 启动Coroutine
        /// </summary>
        /// <param name="coroutine"></param>
        /// <returns></returns>
        public override Coroutine StartMyCoroutine(IEnumerator coroutine)
        {
            return StartCoroutine(coroutine);
        }

        /// <summary>
        /// 停止Coroutine
        /// </summary>
        /// <param name="coroutine"></param>
        public override void StopMyCoroutine(Coroutine coroutine)
        {
            StopCoroutine(coroutine);
        }
    }
}