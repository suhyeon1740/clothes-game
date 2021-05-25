#if UNITY_EDITOR
using UnityEditor;
using UnityEditor.UI;

[CustomEditor(typeof(CustomButton), true)]
public class CustomButtonEditor : ButtonEditor
{
    SerializedProperty pressProperty;
    SerializedProperty realeaseProperty;    

    protected override void OnEnable()
    {
        base.OnEnable();
        pressProperty = serializedObject.FindProperty("pressEvent");
        realeaseProperty = serializedObject.FindProperty("releaseEvent");
    }

    public override void OnInspectorGUI()
    {
        //call the base GUI so we can see all the original
        base.OnInspectorGUI();

        serializedObject.Update();

        EditorGUILayout.Space();
        EditorGUILayout.PropertyField(pressProperty);

        EditorGUILayout.Space();
        EditorGUILayout.PropertyField(realeaseProperty);

        serializedObject.ApplyModifiedProperties();
    }
}
#endif