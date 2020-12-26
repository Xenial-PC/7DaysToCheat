using System;
using UnityEngine;

namespace _7DaysToCheat
{
    internal class Esp : MonoBehaviour
    {
        private EntityEnemy[] _entityEnemies;
        public static Material LineMaterial;
        private readonly Color _espColor = Color.red;

        private static readonly int // All property ids we need to write to
            SrcBlend = Shader.PropertyToID("_SrcBlend"),
            DstBlend = Shader.PropertyToID("_DstBlend"), 
            Cull = Shader.PropertyToID("_Cull"),
            ZWrite = Shader.PropertyToID("_ZWrite");

        public static Material MakeLinesMat()
	{
            if (LineMaterial != null) return LineMaterial; // makes sure the line material has been reset

            LineMaterial = new Material(Shader.Find("Hidden/Internal-Colored")) // creates a new Material with the flags of where the shader is Hidden/Internal-Colored
            {
                hideFlags = HideFlags.HideAndDontSave, shader = {hideFlags = HideFlags.HideAndDontSave} // makes sure the material isn't saved in memory
            };

            LineMaterial.SetInt(SrcBlend, 5); 
            LineMaterial.SetInt(DstBlend, 10);

            LineMaterial.SetInt(Cull, 0);
            LineMaterial.SetInt(ZWrite, 0);

            return LineMaterial;
	}

        public static void MakeLines(Vector3 vs0, Vector3 vs2, Color color)
	{
            MakeLinesMat().SetPass(0);

            GL.Begin(1);
	    GL.Color(color);

	    GL.Vertex3(vs0.x, vs0.y, 0f);
	    GL.Vertex3(vs2.x, vs2.y, 0f);

	    GL.End();
	}

        public void OnGUI()
        {
            try // wrapped in a try and catch to save you from erroring out as new chunks are generated 
            {
                GUI.contentColor = Color.green; // sets the label to green
                GUI.Label(new Rect(50, Screen.height / 2f, 120, 120), @"ESP!"); // creates a label to show esp is enabled

                _entityEnemies = FindObjectsOfType<EntityEnemy>(); // updates the list for the newly spawned enemies 
                for (var i = 0; i < _entityEnemies.Length; i++) // uses a for loop for less overhead as foreach adds a lot 
                {
                    var enemyEntity = _entityEnemies[i]; // sets each new _entityEnemy to enemyEntity

                    if (enemyEntity.gameObject == null || enemyEntity == null) continue; // checks to make sure there is no null object in the list
                    if (enemyEntity.IsDead()) continue; // checks to see if the enemy is even alive

                    var position = enemyEntity.transform.position; // gets the enemy position

                    if (Camera.main == null) continue; // makes sure the main camera is created first

                    var vector = Camera.main.WorldToScreenPoint(position); // W2S function to allow us to create GUI points
                    GUIUtility.ScreenToGUIPoint(vector); // takes the vector point and converts it to GUI point

                    if (!(vector.z > 0f)) continue; // makes sure the enemy is not on top of you

                    var num = Vector3.Distance(enemyEntity.transform.localPosition, vector) - 1000f; // takes the distance of the localPosition and the relative position
                    vector.y = Screen.height - (vector.y + 1f); // centers the box

                    // creates the box
                    MakeLines(new Vector2(vector.x - 25f, vector.y - 25f), new Vector2(vector.x - 25f, vector.y + 25f),
                        _espColor);
                    MakeLines(new Vector2(vector.x + 25f, vector.y - 25f), new Vector2(vector.x + 25f, vector.y + 25f),
                        _espColor);
                    MakeLines(new Vector2(vector.x + 25f, vector.y + 25f), new Vector2(vector.x - 25f, vector.y + 25f),
                        _espColor);
                    MakeLines(new Vector2(vector.x - 25f, vector.y - 25f), new Vector2(vector.x + 25f, vector.y - 25f),
                        _espColor);

                    var position2 = enemyEntity.transform.position;
                    var vector2 = Camera.main.WorldToScreenPoint(position2);

                    if (vector2.z > 0f)
                    {
                        // creates a tracer line
                        vector2.y = Screen.height - vector2.y; // takes the screen height and calculates where the enemy is in that GUI point
                        MakeLines(new Vector2(Screen.width / 2f, Screen.height), vector2, _espColor); // creates the line at the bottom of your screen
                    }

                    GUI.contentColor = _espColor; // sets the color to the current set esp color
                    GUI.Label(new Rect(vector.x - 50f, vector.y + 30f, 300f, 175f), string.Concat( // creates a label and then concats the string
                        "Health: ",
                        enemyEntity.Health,
                        "\nName: ",
                        enemyEntity.EntityName,
                        "\nExperience Value: ",
                        enemyEntity.ExperienceValue,
                        "\nSleeping: ",
                        enemyEntity.IsSleeping,
                        "\nDistance: ", num
                    ));
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }
    }
}
