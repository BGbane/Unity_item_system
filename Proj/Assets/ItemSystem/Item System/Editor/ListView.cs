using UnityEngine;
using UnityEditor;
using System.Collections;



namespace BG.ItemSystem.Editor
{
    public partial class ISQualityDatabaseEditor
    {


        
        void ListView()
        {
          _skrollPos = EditorGUILayout.BeginScrollView(_skrollPos, GUILayout.ExpandHeight(true)); //SKROLL GUI

            DisplayQualities();    
            EditorGUILayout.EndScrollView();
        }

        private void DisplayQualities()
        {
            for (int i = 0; i < qualityDatabase.Count; i++)
            {
                GUILayout.BeginHorizontal("BOX");
                if (qualityDatabase.Get(i).Icon)
                {
                    selectedTexture = qualityDatabase.Get(i).Icon.texture;

                }
                else
                {
                    selectedTexture = null;
                }

           if(   GUILayout.Button(selectedTexture, GUILayout.Width(SPRITE_BUTTON_SIZE), GUILayout.Height(SPRITE_BUTTON_SIZE)))
              {
                  int controlorID = EditorGUIUtility.GetControlID(FocusType.Passive);
                  EditorGUIUtility.ShowObjectPicker<Sprite>(null, true, null, controlorID);
                  selectedIndex = i;

              }

              string commandName = Event.current.commandName;
              if (commandName == "ObjectSelectorUpdated")
              {
                  if (selectedIndex != -1)
                  { 
                  qualityDatabase.Get(selectedIndex).Icon = (Sprite)EditorGUIUtility.GetObjectPickerObject();
             //     selectedIndex = -1;
                  }
                  Repaint();
              }

              GUILayout.BeginVertical();
              qualityDatabase.Get(i).Name =  GUILayout.TextField(qualityDatabase.Get(i).Name);
              
                
                if(GUILayout.Button("X",GUILayout.Width(50)))
                {
                    if(EditorUtility.DisplayDialog("Delete",
                        "Are you sure that you want to delete: " +  qualityDatabase.Get(i).Name + " from database?",
                        "Delete",
                        "Cancel" ))
                    {
                        qualityDatabase.Remove(i);
                    }
                }
                GUILayout.EndVertical();
                GUILayout.EndHorizontal();
            }
        }

    }
}
