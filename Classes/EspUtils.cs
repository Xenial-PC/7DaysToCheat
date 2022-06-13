using System;
using UnityEngine;
using UnityEditor;

namespace _7DaysToCheat.Classes
{
    static class EspUtils
    {
        // This is not my class its from another UnityCheat awhile back just modified so all credits go to them not me
        private static Texture2D _drawingTex;
        private static Texture2D _whiteTexture;

        private static Color _lastTexColor;

        private static Material _drawMaterial;
        static float theta_scale = 0.01f;
        static int size;
        static float radius = 3f;
        static LineRenderer lineRenderer;

        private static GUIStyle __style = new GUIStyle();
        private static GUIStyle __outlineStyle = new GUIStyle();

        static EspUtils()
        {
            _whiteTexture = Texture2D.whiteTexture;
            _drawingTex = new Texture2D(1, 1);

            _drawMaterial = new Material(Shader.Find("Hidden/Internal-Colored"))
            {
                hideFlags = (HideFlags)61
            };

            _drawMaterial.SetInt("_SrcBlend", 5);
            _drawMaterial.SetInt("_DstBlend", 10);
            _drawMaterial.SetInt("_Cull", 0);
            _drawMaterial.SetInt("_ZWrite", 0);
        }

        public static void ApplyWireFrame(Entity entity, Color color)
        {
            var wireFrameShader = new Material(ResourceHandler.WireFrameShader)
            {
                hideFlags = HideFlags.HideAndDontSave
            };
            var wireColor = Shader.PropertyToID("_WireColor");

            var material = new Material(wireFrameShader);
            foreach (var renderer in entity.GetComponentsInChildren<Renderer>())
            {
                renderer.material = material;
                renderer.material.SetColor(wireColor, color);
            }
        }

        public static void ApplyWireFrameToObject(GameObject @object, Color color)
        {
            try
            {
                var wireFrameShader = new Material(ResourceHandler.WireFrameShader)
                {
                    hideFlags = HideFlags.HideAndDontSave
                };
                var wireColor = Shader.PropertyToID("_WireColor");

                var material = new Material(wireFrameShader);
                foreach (var renderer in @object.GetComponentsInChildren<Renderer>())
                {
                    renderer.material = material;
                    renderer.material.SetColor(wireColor, color);
                }
            }
            catch (Exception e)
            {
                // ignore
            }
        }

        public static void ApplyWeaponSkin(GameObject @object, string filename, int width, int height)
        {
            try
            {
                var skin = ResourceHandler.MaterialCreator.LoadImage(filename, width, height);
                foreach (var renderer in @object.GetComponentsInChildren<Renderer>())
                {
                    renderer.material.mainTexture = skin;
                }
            }
            catch (Exception e)
            {
                // ignore
            }
        }

        public static void ApplyArmSkin(GameObject @object, string filename, int width, int height)
        {
            try
            {
                var skin = ResourceHandler.MaterialCreator.LoadImage(filename, width, height);
                foreach (var renderer in @object.GetComponentsInChildren<Renderer>())
                {
                    if (renderer.gameObject.name.Contains("FP_ARM") || renderer.material.name == "HD_Hands")
                        renderer.material.mainTexture = skin;
                }
            }
            catch (Exception e)
            {
                // ignore
            }
        }

        public static Color GetHealthColor(float health, float maxHealth)
        {
            var result = Color.green;
            var percentage = health / maxHealth;

            result = percentage >= 0.75f ? Color.green : Color.yellow;

            if (percentage <= 0.25f)
            {
                result = Color.red;
            }

            return result;
        }

        public static void DrawCircle(Color col, Vector2 center, float radius)
        {
            GL.PushMatrix();

            if (!_drawMaterial.SetPass(0))
            {
                GL.PopMatrix();
                return;
            }

            GL.Begin(1);
            GL.Color(col);

            for (var num = 0f; num < 6.28318548f; num += 0.05f)
            {
                GL.Vertex(new Vector3(Mathf.Cos(num) * radius + center.x, Mathf.Sin(num) * radius + center.y));
                GL.Vertex(new Vector3(Mathf.Cos(num + 0.05f) * radius + center.x, Mathf.Sin(num + 0.05f) * radius + center.y));
            }

            GL.End();
            GL.PopMatrix();
        }

        public static void DrawCircleFilled(Color col, Vector2 pos, Vector2 radious)
        {
            GUI.color = col;
            var a = Resources.Load<Texture2D>(@"Resources\unity_builtin_extra\Knob");
            GUI.DrawTexture(new Rect(pos, radious), a);
        }

        public static void DrawLine(Vector2 start, Vector2 end, Color color, float width)
        {
            var oldColor = GUI.color;
            var rad2deg = 360 / (Math.PI * 2);
            var d = end - start;

            var a = (float)rad2deg * Mathf.Atan(d.y / d.x);
            if (d.x < 0)
                a += 180;

            var width2 = (int)Mathf.Ceil(width / 2);

            GUIUtility.RotateAroundPivot(a, start);
            GUI.color = color;

            GUI.DrawTexture(new Rect(start.x, start.y - width2, d.magnitude, width), Texture2D.whiteTexture, ScaleMode.StretchToFill);
            GUIUtility.RotateAroundPivot(-a, start);

            GUI.color = oldColor;
        }

        public static void OutlineBox(Vector2 pos, Vector2 size, Color color, float width = 1)
        {
            var oldColor = GUI.color;
            GUI.color = color;

            GUI.DrawTexture(new Rect(pos.x, pos.y, width, size.y), _whiteTexture);
            GUI.DrawTexture(new Rect(pos.x + size.x, pos.y, width, size.y), _whiteTexture);
            GUI.DrawTexture(new Rect(pos.x, pos.y, size.x, width), _whiteTexture);
            GUI.DrawTexture(new Rect(pos.x, pos.y + size.y, size.x, width), _whiteTexture);

            GUI.color = oldColor;
        }

        public static bool IsOnScreen(Vector3 position)
        {
            return position.y > 0.01f && position.y < Screen.height - 5f && position.z > 0.01f;
        }

        public static void CornerBox(Vector2 head, float width, float height, float thickness, Color color, bool outline)
        {
            var num = (int)(width / 4f);
            var num2 = num;

            if (outline)
            {
                RectFilled(head.x - width / 2f - 1f, head.y - 1f, num + 2, 3f, Color.black);
                RectFilled(head.x - width / 2f - 1f, head.y - 1f, 3f, num2 + 2, Color.black);
                RectFilled(head.x + width / 2f - num - 1f, head.y - 1f, num + 2, 3f, Color.black);
                RectFilled(head.x + width / 2f - 1f, head.y - 1f, 3f, num2 + 2, Color.black);
                RectFilled(head.x - width / 2f - 1f, head.y + height - 4f, num + 2, 3f, Color.black);
                RectFilled(head.x - width / 2f - 1f, head.y + height - num2 - 4f, 3f, num2 + 2, Color.black);
                RectFilled(head.x + width / 2f - num - 1f, head.y + height - 4f, num + 2, 3f, Color.black);
                RectFilled(head.x + width / 2f - 1f, head.y + height - num2 - 4f, 3f, num2 + 3, Color.black);
            }

            RectFilled(head.x - width / 2f, head.y, num, 1f, color);
            RectFilled(head.x - width / 2f, head.y, 1f, num2, color);
            RectFilled(head.x + width / 2f - num, head.y, num, 1f, color);
            RectFilled(head.x + width / 2f, head.y, 1f, num2, color);
            RectFilled(head.x - width / 2f, head.y + height - 3f, num, 1f, color);
            RectFilled(head.x - width / 2f, head.y + height - num2 - 3f, 1f, num2, color);
            RectFilled(head.x + width / 2f - num, head.y + height - 3f, num, 1f, color);
            RectFilled(head.x + width / 2f, head.y + height - num2 - 3f, 1f, num2 + 1, color);
        }

        public static void RectFilled(float x, float y, float width, float height, Color color)
        {
            if (color != _lastTexColor)
            {
                _drawingTex.SetPixel(0, 0, color);
                _drawingTex.Apply();

                _lastTexColor = color;
            }

            GUI.DrawTexture(new Rect(x, y, width, height), _drawingTex);
        }

        public static void DrawString(Vector2 pos, string text, Color color, bool center = true, int size = 12, FontStyle fontStyle = FontStyle.Bold, int depth = 1)
        {
            __style.fontSize = size;
            __style.richText = true;
            __style.normal.textColor = color;
            __style.fontStyle = fontStyle;

            __outlineStyle.fontSize = size;
            __outlineStyle.richText = true;
            __outlineStyle.normal.textColor = new Color(0f, 0f, 0f, 1f);
            __outlineStyle.fontStyle = fontStyle;

            var content = new GUIContent(text);
            var content2 = new GUIContent(text);
            if (center)
            {
                pos.x -= __style.CalcSize(content).x / 2f;
            }
            switch (depth)
            {
                case 0:
                    GUI.Label(new Rect(pos.x, pos.y, 300f, 25f), content, __style);
                    break;
                case 1:
                    GUI.Label(new Rect(pos.x + 1f, pos.y + 1f, 300f, 25f), content2, __outlineStyle);
                    GUI.Label(new Rect(pos.x, pos.y, 300f, 25f), content, __style);
                    break;
                case 2:
                    GUI.Label(new Rect(pos.x + 1f, pos.y + 1f, 300f, 25f), content2, __outlineStyle);
                    GUI.Label(new Rect(pos.x - 1f, pos.y - 1f, 300f, 25f), content2, __outlineStyle);
                    GUI.Label(new Rect(pos.x, pos.y, 300f, 25f), content, __style);
                    break;
                case 3:
                    GUI.Label(new Rect(pos.x + 1f, pos.y + 1f, 300f, 25f), content2, __outlineStyle);
                    GUI.Label(new Rect(pos.x - 1f, pos.y - 1f, 300f, 25f), content2, __outlineStyle);
                    GUI.Label(new Rect(pos.x, pos.y - 1f, 300f, 25f), content2, __outlineStyle);
                    GUI.Label(new Rect(pos.x, pos.y + 1f, 300f, 25f), content2, __outlineStyle);
                    GUI.Label(new Rect(pos.x, pos.y, 300f, 25f), content, __style);
                    break;
            }
        }
    }
}
