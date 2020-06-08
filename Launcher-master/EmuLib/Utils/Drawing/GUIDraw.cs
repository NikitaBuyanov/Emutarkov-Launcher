using UnityEngine;

namespace EmuLib.Utils.Drawing
{
	internal class GUIDraw
	{
		private class dColors
		{
			public static Color Black = new Color(0f, 0f, 0f, 1f);
			public static Color HeavyGrey = new Color(1f, 1f, 1f, 0.6f);
			public static Color White = new Color(1f, 1f, 1f, 1f);
		}

		public static class Dot
		{
			private static class d
			{
				public static Texture2D lineTex = new Texture2D(1, 1);
				public static Vector2 vectorA = Vector2.zero;
				public static Rect rectA = Rect.zero;
				public static Color bColor;
				public static float tOffset = 0f;
				public static Texture2D patternTexture = new Texture2D(1, 1);
				public static Vector2 Crosshair2dCenter_sw = new Vector2(Screen.width / 2f - 2f, Screen.height / 2f - 2f);
				public static Vector2 Crosshair2dCenter_ac = new Vector2(Screen.width / 2f - 1f, Screen.height / 2f - 1f);
				public static Vector2 Crosshair2dVector = Vector2.zero;
			}

			public static void DrawCrosshairOnCenter()
			{
				Dot.Draw(d.Crosshair2dCenter_sw, dColors.Black, 4f);
				Dot.Draw(d.Crosshair2dCenter_ac, dColors.White, 2f);
			}

			public static void DrawCrosshairFromVector(Vector3 vector)
			{
				if (vector.x == 0f && vector.y == 0f)
				{
					return; // if [0,0] - return;
				}

				d.Crosshair2dVector.x = vector.x - 2f;
				d.Crosshair2dVector.y = Screen.height - vector.y - 1f;
				Dot.Draw(d.Crosshair2dVector, dColors.Black, 4f);

				d.Crosshair2dVector.x += 1f;
				d.Crosshair2dVector.y += 1f;
				Dot.Draw(d.Crosshair2dVector, dColors.White, 2f);
			}

			public static void Draw(Vector2 Position, Color color, float thickness)
			{
				if (!d.lineTex)
				{
					d.lineTex = d.patternTexture;
				}

				d.tOffset = Mathf.Ceil(thickness / 2f);
				d.bColor = GUI.color;
				d.rectA.x = Position.x;
				d.rectA.y = Position.y - d.tOffset;
				d.rectA.width = thickness;
				d.rectA.height = thickness;

				GUI.color = color;
				GUI.DrawTexture(d.rectA, d.lineTex);
				GUI.color = d.bColor;
			}
		}

		public static class Text
		{
			private static class d
			{
				public static Vector2 vectorA = Vector2.zero;
				public static GUIStyle bStyle;
				public static GUIContent bContent = new GUIContent();
				public static GUIStyle cStyle = new GUIStyle() { fontSize = 12 };
				public static Rect rectA = Rect.zero;
			}

			public static void Draw(float v1x, float v1y, float v2x, float v2y, string content, Color txtColor, GUIStyle guiStyle, bool shadow = true)
			{
				d.rectA.x = v1x;
				d.rectA.y = v1y;
				d.rectA.width = v2x;
				d.rectA.height = v2y;
				Draw(d.rectA, content, guiStyle, txtColor, shadow);
			}

			public static void Draw(Rect rect, string content, Color txtColor, GUIStyle guiStyle, bool shadow = true)
			{
				Draw(rect, content, guiStyle, txtColor, shadow);
			}

			public static void Draw(Rect rect, string content, GUIStyle guiStyle, Color txtColor, bool shadow = true)
			{
				if (!shadow)
				{
					d.bStyle = guiStyle;
					d.bStyle.normal.textColor = txtColor;
					GUI.Label(rect, content, d.bStyle);
					return;
				}

				d.bContent.text = content;
				d.vectorA.x = 1f;
				d.vectorA.y = 1f;

				DrawShadowed(rect, d.bContent, guiStyle, txtColor, dColors.Black, d.vectorA);
			}

			public static void Draw(Rect rect, string content, Color txtColor, bool shadow = true)
			{
				if (!shadow)
				{
					d.bStyle = d.cStyle;
					d.bStyle.normal.textColor = txtColor;
					GUI.Label(rect, content, d.bStyle);
					return;
				}

				d.bContent.text = content;
				d.vectorA.x = 1f;
				d.vectorA.y = 1f;

				DrawShadowed(rect, d.bContent, d.cStyle, txtColor, dColors.Black, d.vectorA);
			}

			public static void DrawShadowed(Rect rect, GUIContent content, GUIStyle style, Color txtColor, Color shadowColor, Vector2 direction)
			{
				d.bStyle = style;

				style.normal.textColor = shadowColor;
				rect.x += direction.x;
				rect.y += direction.y;
				GUI.Label(rect, content, style);

				style.normal.textColor = txtColor;
				rect.x -= direction.x;
				rect.y -= direction.y;
				GUI.Label(rect, content, style);

				style = d.bStyle;
			}
		}
		public static class Line
		{
			// temporal iCorpse used only in this scope to remove ram overuse and speed up code
			private static class d
			{
				public static Texture2D lineTex = new Texture2D(1, 1);
				public static Texture2D patternTexture = new Texture2D(1, 1);
				public static Matrix4x4 i_M4x4 = Matrix4x4.zero;
				public static Vector2 vectorA = Vector2.zero;
				public static Vector2 vectorB = Vector2.zero;
				public static float Angle = 0f;
				public static Color bColor;
				public static Rect rectA = Rect.zero;
			}

			// add more overloads below if needed
			public static void Draw(Rect rect, Color color, float width)
			{
				d.vectorA.x = rect.x;
				d.vectorA.y = rect.y;
				d.vectorB.x = rect.x + rect.width;
				d.vectorB.y = rect.y + rect.height;

				Draw(d.vectorA, d.vectorB, color, width);
			}

			public static void Draw(Vector2 pointA, Vector2 pointB, Color color) { Draw(pointA, pointB, color, 1.0f); }

			// main drawing function
			public static void Draw(Vector2 pointA, Vector2 pointB, Color color, float width)
			{
				d.i_M4x4 = GUI.matrix;

				if (!d.lineTex)
				{
					d.lineTex = d.patternTexture;
				}

				d.bColor = GUI.color;
				GUI.color = color;
				d.Angle = Vector3.Angle(pointB - pointA, Vector2.right);

				if (pointA.y > pointB.y)
				{
					d.Angle = -d.Angle;
				}

				d.vectorA.x = (pointB - pointA).magnitude;
				d.vectorA.y = width;
				d.vectorB.x = pointA.x;
				d.vectorB.y = pointA.y + 0.5f;
				GUIUtility.ScaleAroundPivot(d.vectorA, d.vectorB);
				GUIUtility.RotateAroundPivot(d.Angle, pointA);
				d.rectA.x = pointA.x;
				d.rectA.y = pointA.y;
				d.rectA.width = 1f;
				d.rectA.height = 1f;
				GUI.DrawTexture(d.rectA, d.lineTex);
				GUI.matrix = d.i_M4x4;
				GUI.color = d.bColor;
			}
		}

		public static class Box
		{
			private static class d
			{
				public static Vector2 vectorA = Vector2.zero;
				public static Vector2 vectorB = Vector2.zero;
			}

			public static void Draw(float x, float y, float w, float h, Color color)
			{
				d.vectorA.x = x;
				d.vectorA.y = y;
				d.vectorB.x = x + w;
				d.vectorB.y = y;
				Line.Draw(d.vectorA, d.vectorA, color);

				d.vectorB.x = x;
				d.vectorB.y = y + h;
				Line.Draw(d.vectorA, d.vectorA, color);

				d.vectorA.x = x + w;
				d.vectorB.x = x + w;
				Line.Draw(d.vectorA, d.vectorA, color);

				d.vectorA.x = x;
				d.vectorA.y = y + h;
				Line.Draw(d.vectorA, d.vectorA, color);
			}
		}
	}
}
