using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;

namespace GameLogic
{
    /// <summary>
    /// 摄像机漫游
    /// </summary>
    public class CameraRoam : MonoBehaviour
    {
        //隐藏光标
        public bool hideCursor = true;

        public float normalSpeed = 25.0f;
        public float shiftSpeed = 54.0f;
        public float speedCap = 54.0f;
        public float cameraSensitivity = 0.6f;
        private float totalSpeed = 1.0f;
        //旋转速度
        public float rotationSpeed = 5f;
        //上下旋转角度限制
        public float maxRot = 90f;                          //最大旋转角度
        public float minRot = -90f;                         //最小旋转角度
        //旋转缓冲速度
        public float lerpSpeed = 10f;
        private float targetRotationX = 0f;
        private float targetRotationY = 0f;

        private Transform thisTransform;

        Mouse mouse;
        Touchscreen touchscreen;
        Keyboard keyboard;

        public void Start()
        {
            if (hideCursor)
            {
                HideCursor();
            }

            thisTransform = transform;

            mouse = Mouse.current;
            touchscreen = Touchscreen.current;
            keyboard = Keyboard.current;
        }

        private void Update()
        {
            // 检查是否按下了Alt键
            if (keyboard[Key.LeftAlt].wasPressedThisFrame)
            {
                DisplayCursor();
            }
            else if (keyboard[Key.LeftAlt].wasReleasedThisFrame)
            {
                if (hideCursor)
                {
                    HideCursor();
                }
            }

            UpdateCameraRotation();

            Vector3 cameraVelocity = GetBaseInput();

            if (keyboard.leftShiftKey.isPressed)
            {
                HandleShiftMovement(ref cameraVelocity);
            }
            else
            {
                totalSpeed = Mathf.Clamp(totalSpeed * 0.5f, 1f, 1000f);
                cameraVelocity *= normalSpeed;
            }

            cameraVelocity *= Time.deltaTime;
            UpdateCameraPosition(cameraVelocity);
        }

        private void UpdateCameraRotation()
        {
            // 获取鼠标输入的旋转增量
            float rotationXInput = -mouse.delta.y.ReadValue() * cameraSensitivity;
            float rotationYInput = mouse.delta.x.ReadValue() * cameraSensitivity;
            // 根据旋转速度进行摄像机的旋转
            targetRotationX += rotationXInput * rotationSpeed;
            targetRotationY += rotationYInput * rotationSpeed;
            // 对上下旋转角度进行限制
            targetRotationX = Mathf.Clamp(targetRotationX, minRot, maxRot);
            // 根据旋转角度更新摄像机的欧拉角，Quaternion.Lerp可以使摄像机旋转更加平滑
            Quaternion targetRotation = Quaternion.Euler(targetRotationX, targetRotationY, 0f);
            transform.rotation = Quaternion.Lerp(transform.rotation, targetRotation, lerpSpeed * Time.deltaTime);
        }

        private void HandleShiftMovement(ref Vector3 cameraVelocity)
        {
            totalSpeed += Time.deltaTime;
            cameraVelocity = cameraVelocity * totalSpeed * shiftSpeed;
            cameraVelocity.x = Mathf.Clamp(cameraVelocity.x, -speedCap, speedCap);
            cameraVelocity.y = Mathf.Clamp(cameraVelocity.y, -speedCap, speedCap);
            cameraVelocity.z = Mathf.Clamp(cameraVelocity.z, -speedCap, speedCap);
        }

        private Vector3 GetBaseInput()
        {
            float horizontalInput = keyboard.dKey.isPressed ? 1 : keyboard.aKey.isPressed ? -1 : 0;
            float verticalInput = keyboard.wKey.isPressed ? 1 : keyboard.sKey.isPressed ? -1 : 0;

            return new Vector3(horizontalInput, 0, verticalInput);
        }

        private void UpdateCameraPosition(Vector3 cameraVelocity)
        {
            thisTransform.Translate(cameraVelocity);
        }

        public void DisplayCursor()
        {
            Cursor.visible = true;
            Cursor.lockState = CursorLockMode.None;
        }

        public void HideCursor()
        {
            Cursor.visible = false;
            Cursor.lockState = CursorLockMode.Locked;
        }
    }
}