﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using UnityEngine;
using UnityEngine.UI;
using Object = System.Object;

namespace GameLogic
{
    /// <summary>
    /// 游戏对象扩展
    /// </summary>
    public static class GameObjectExtensions
    {
        /// <summary>
        /// 设置宽
        /// </summary>
        /// <param name="rectTrans"></param>
        /// <param name="width"></param>
        public static void SetWidth(this RectTransform rectTrans, float width)
        {
            rectTrans.sizeDelta = new Vector2(width, rectTrans.sizeDelta.y);
        }

        /// <summary>
        /// 设置高
        /// </summary>
        /// <param name="rectTrans"></param>
        /// <param name="height"></param>
        public static void SetHeight(this RectTransform rectTrans, float height)
        {
            rectTrans.sizeDelta = new Vector2(rectTrans.sizeDelta.x, height);
        }
        /// <summary>
        /// 获取位置的X轴
        /// </summary>
        /// <param name="t"></param>
        /// <param name="newX"></param>
        public static void SetPositionX(this Transform t, float newX)
        {
            t.position = new Vector3(newX, t.position.y, t.position.z);
        }
        /// <summary>
        /// 获取位置的Y轴
        /// </summary>
        /// <param name="t"></param>
        /// <param name="newY"></param>
        public static void SetPositionY(this Transform t, float newY)
        {
            t.position = new Vector3(t.position.x, newY, t.position.z);
        }
        /// <summary>
        /// 获取位置的Z轴
        /// </summary>
        /// <param name="t"></param>
        /// <param name="newZ"></param>
        public static void SetPositionZ(this Transform t, float newZ)
        {
            t.position = new Vector3(t.position.x, t.position.y, newZ);
        }
        /// <summary>
        /// 获取本地位置的X轴
        /// </summary>
        /// <param name="t"></param>
        /// <param name="newX"></param>
        public static void SetLocalPositionX(this Transform t, float newX)
        {
            t.localPosition = new Vector3(newX, t.localPosition.y, t.localPosition.z);
        }
        /// <summary>
        /// 获取本地位置的Y轴
        /// </summary>
        /// <param name="t"></param>
        /// <param name="newY"></param>
        public static void SetLocalPositionY(this Transform t, float newY)
        {
            t.localPosition = new Vector3(t.localPosition.x, newY, t.localPosition.z);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="t"></param>
        /// <param name="newZ"></param>
        public static void SetLocalPositionZ(this Transform t, float newZ)
        {
            t.localPosition = new Vector3(t.localPosition.x, t.localPosition.y, newZ);
        }
        /// <summary>
        /// 设置缩放为0
        /// </summary>
        /// <param name="t"></param>
        /// <param name="newScale"></param>
        public static void SetLocalScale(this Transform t, Vector3 newScale)
        {
            t.localScale = newScale;
        }
        /// <summary>
        /// 设置本地缩放为0
        /// </summary>
        /// <param name="t"></param>
        public static void SetLocalScaleZero(this Transform t)
        {
            t.localScale = Vector3.zero;
        }
        /// <summary>
        /// 获取位置的X轴
        /// </summary>
        /// <param name="t"></param>
        /// <returns></returns>
        public static float GetPositionX(this Transform t)
        {
            return t.position.x;
        }
        /// <summary>
        /// 获取位置的Y轴
        /// </summary>
        /// <param name="t"></param>
        /// <returns></returns>
        public static float GetPositionY(this Transform t)
        {
            return t.position.y;
        }
        /// <summary>
        /// 获取位置的Z轴
        /// </summary>
        /// <param name="t"></param>
        /// <returns></returns>
        public static float GetPositionZ(this Transform t)
        {
            return t.position.z;
        }
        /// <summary>
        /// 获取本地位置的X轴
        /// </summary>
        /// <param name="t"></param>
        /// <returns></returns>
        public static float GetLocalPositionX(this Transform t)
        {
            return t.localPosition.x;
        }
        /// <summary>
        /// 获取本地位置的Y轴
        /// </summary>
        /// <param name="t"></param>
        /// <returns></returns>
        public static float GetLocalPositionY(this Transform t)
        {
            return t.localPosition.y;
        }
        /// <summary>
        /// 获取本地位置的Z轴
        /// </summary>
        /// <param name="t"></param>
        /// <returns></returns>
        public static float GetLocalPositionZ(this Transform t)
        {
            return t.localPosition.z;
        }
        /// <summary>
        /// 判断活动状态
        /// </summary>
        /// <param name="t"></param>
        /// <returns></returns>
        public static bool IsActive(this Transform t)
        {
            return t?.gameObject.activeInHierarchy ?? false;
        }
        /// <summary>
        /// 变换转矩阵变换
        /// </summary>
        /// <param name="t"></param>
        /// <returns></returns>
        public static RectTransform RectTransform(this Transform t)
        {
            return t?.gameObject.GetComponent<RectTransform>();
        }
        /// <summary>
        /// 判断刚体是否存在
        /// </summary>
        /// <param name="gobj"></param>
        /// <returns></returns>
        public static bool HasRigidbody(this GameObject gobj)
        {
            return gobj.GetComponent<Rigidbody>() != null;
        }
        /// <summary>
        /// 判断动画是否存在
        /// </summary>
        /// <param name="gobj"></param>
        /// <returns></returns>
        public static bool HasAnimation(this GameObject gobj)
        {
            return gobj.GetComponent<Animation>() != null;
        }
        /// <summary>
        /// 设置动画速度
        /// </summary>
        /// <param name="anim"></param>
        /// <param name="newSpeed"></param>
        public static void SetSpeed(this Animation anim, float newSpeed)
        {
            anim[anim.clip.name].speed = newSpeed;
        }
        /// <summary>
        /// v3转v2
        /// </summary>
        /// <param name="vec"></param>
        /// <returns></returns>
        public static Vector2 ToVector2(this Vector3 vec)
        {
            return new Vector2(vec.x, vec.y);
        }
        /// <summary>
        /// 设置活动状态
        /// </summary>
        /// <param name="com"></param>
        /// <param name="visible"></param>
        public static void SetActive(this Component com, bool visible)
        {
            if (com && com.gameObject && com.gameObject.activeSelf != visible) com.gameObject.SetActive(visible);
        }
        /// <summary>
        /// 设置活动状态（反向）
        /// </summary>
        /// <param name="go"></param>
        /// <param name="visible"></param>
        public static void SetActiveReverse(this GameObject go, bool visible)
        {
            if (go && go.activeSelf != visible) go.SetActive(visible);
        }
        /// <summary>
        /// 设置名字
        /// </summary>
        /// <param name="go"></param>
        /// <param name="name"></param>
        public static void SetName(this GameObject go, string name)
        {
            if (go && go.name != name) go.name = name;
        }

        /// <summary>
        /// 获取附加到给定游戏对象的组件
        /// 如果找不到，则附加一个新的并返回
        /// </summary>
        /// <param name="gameObject">Game object.</param>
        /// <returns>Previously or newly attached component.</returns>
        public static T GetOrAddComponent<T>(this GameObject gameObject) where T : Component
        {
            return gameObject.GetComponent<T>() ?? gameObject.AddComponent<T>();
        }

        /// <summary>
        /// 检查游戏对象是否附加了类型为T的组件
        /// </summary>
        /// <param name="gameObject">Game object.</param>
        /// <returns>True when component is attached.</returns>
        public static bool HasComponent<T>(this GameObject gameObject) where T : Component
        {
            return gameObject.GetComponent<T>() != null;
        }

        /// <summary>
        /// 搜索子物体组件
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="go"></param>
        /// <param name="subnode"></param>
        /// <returns></returns>
        public static T Get<T>(this GameObject go, string subnode) where T : Component
        {
            if (go != null)
            {
                Transform sub = go.transform.Find(subnode);
                if (sub != null) return sub.GetComponent<T>();
            }
            return null;
        }

        /// <summary>
        /// 递归设置游戏对象的层
        /// </summary>
        public static void SetLayer(GameObject go, int layer)
        {
            go.layer = layer;

            foreach (Transform child in go.transform)
            {
                SetLayer(child.gameObject, layer);
            }
        }

        #region 查找子对象
        /// <summary>
        /// 查找子对象
        /// </summary>
        /// <param name="go"></param>
        /// <param name="subnode"></param>
        /// <returns></returns>
        public static GameObject Child(this GameObject go, string subnode)
        {
            return Child(go.transform, subnode);
        }

        /// <summary>
        /// 查找子对象
        /// </summary>
        /// <param name="go"></param>
        /// <param name="subnode"></param>
        /// <returns></returns>
        public static GameObject Child(Transform go, string subnode)
        {
            Transform tran = go.Find(subnode);
            return tran?.gameObject;
        }
        #endregion

        #region 取平级对象
        /// <summary>
        /// 取平级对象
        /// </summary>
        /// <param name="go"></param>
        /// <param name="subnode"></param>
        /// <returns></returns>
        public static GameObject Peer(this GameObject go, string subnode)
        {
            return Peer(go.transform, subnode);
        }

        /// <summary>
        /// 取平级对象
        /// </summary>
        /// <param name="go"></param>
        /// <param name="subnode"></param>
        /// <returns></returns>
        public static GameObject Peer(Transform go, string subnode)
        {
            Transform tran = go.parent.Find(subnode);
            return tran?.gameObject;
        }
        #endregion

        /// <summary>
        /// 清除所有子节点
        /// </summary>
        /// <param name="go"></param>
        public static void ClearChild(GameObject go)
        {
            var tran = go.transform;

            while (tran.childCount > 0)
            {
                var child = tran.GetChild(0);

                if (Application.isEditor && !Application.isPlaying)
                {
                    GameObject.DestroyImmediate(child.gameObject);
                }
                else
                {
                    GameObject.Destroy(child.gameObject);
                }
                child.parent = null;
            }
        }

        /// <summary>
        /// 清除所有子节点
        /// </summary>
        /// <param name="go"></param>
        public static void ThisClearChild(this GameObject go)
        {
            ClearChild(go);
        }

        #region UGUITool
        /// <summary>
        /// 设置文本内容
        /// </summary>
        /// <param name="textStr">文本内容</param>
        /// <returns></returns>
        public static Text SetText(this GameObject obj, string name, string textStr)
        {
            var text = obj.Get<Text>(name);
            text.text = textStr;
            return text;
        }
        /// <summary>
        /// 设置按钮点击回调
        /// </summary>
        /// <param name="onClick">点击回调</param>
        /// <returns></returns>
        public static Button SetButton(this GameObject obj, string name, Action<GameObject> onClick)
        {
            var btn = obj.Get<Button>(name);
            btn.onClick.AddListener(() =>
            {
                if (null != onClick)
                {
                    onClick(btn.gameObject);
                }
            });
            return btn;
        }

        /// <summary>
        /// 设置输入框文本输入完毕回调
        /// </summary>
        /// <param name="onEndEdit">文本输入完毕后回调</param>
        /// <returns></returns>
        public static InputField SetInputField(this GameObject obj, string name, Action<string> onEndEdit)
        {
            var input = obj.Get<InputField>(name);
            input.onEndEdit.AddListener((v) =>
            {
                if (null != onEndEdit)
                {
                    onEndEdit(v);
                }
            });
            return input;
        }

        /// <summary>
        /// 设置下拉框选择回调
        /// </summary>
        /// <param name="onValueChanged">选择回调</param>
        /// <returns></returns>
        public static Dropdown SetDropDown(this GameObject obj, string name, Action<int> onValueChanged)
        {
            var dropdown = obj.Get<Dropdown>(name);
            dropdown.onValueChanged.RemoveAllListeners();
            dropdown.onValueChanged.AddListener((v) =>
            {
                if (null != onValueChanged)
                    onValueChanged(v);
            });

            return dropdown;
        }

        /// <summary>
        /// 设置单选框选择回调
        /// </summary>
        /// <param name="onValueChanged">选择回调</param>
        /// <returns></returns>
        public static Toggle SetToggle(this GameObject obj, string name, Action<bool> onValueChanged)
        {
            var toogle = obj.Get<Toggle>(name);
            toogle.onValueChanged.RemoveAllListeners();
            toogle.onValueChanged.AddListener((v) =>
            {
                if (null != onValueChanged)
                    onValueChanged(v);
            });

            return toogle;
        }

        /// <summary>
        /// 设置单选框选择回调
        /// </summary>
        /// <param name="onValueChanged">选择回调</param>
        /// <returns></returns>
        public static Slider SetSlider(this GameObject obj, string name, Action<float> onValueChanged)
        {
            var slider = obj.Get<Slider>(name);
            slider.onValueChanged.RemoveAllListeners();
            slider.onValueChanged.AddListener((v) =>
            {
                if (null != onValueChanged)
                    onValueChanged(v);
            });

            return slider;
        }
        #endregion
    }
}