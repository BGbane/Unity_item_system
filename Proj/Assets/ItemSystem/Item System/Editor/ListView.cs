using UnityEngine;
using UnityEditor;
using System.Collections;
using System;



namespace BG.ItemSystem.Editor
{
    public partial class ISItemDatabaseEditor
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
              GUILayout.BeginVertical("BOX", GUILayout.Width(500));
              GUILayout.Label("Item Name:");
              qualityDatabase.Get(i).Name =  GUILayout.TextField(qualityDatabase.Get(i).Name);

              GUILayout.Label("Item Multi Name:");
              qualityDatabase.Get(i).MultyName = GUILayout.TextField(qualityDatabase.Get(i).MultyName);

              GUILayout.Label("Item Complete Name:");
              qualityDatabase.Get(i).CompleteName = GUILayout.TextField(qualityDatabase.Get(i).CompleteName);  

              GUILayout.BeginVertical();
              if (qualityDatabase.Get(i).Normal = GUILayout.Toggle(qualityDatabase.Get(i).Normal, "" + "Normal Item"))
              { 
                
              }

              if (qualityDatabase.Get(i).Partial = GUILayout.Toggle(qualityDatabase.Get(i).Partial, "" + "Partial Item"))
              {

              }

              if (qualityDatabase.Get(i).Stack = GUILayout.Toggle(qualityDatabase.Get(i).Stack, "" + "Stack Item"))
              {

              }
              GUILayout.EndVertical();

              GUILayout.BeginHorizontal();
              GUILayout.BeginVertical();
              #region Icon
              GUILayout.Label("Item Icon:");
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
                  selectedIndexMI = -1;
                  selectedIndexCI = -1;
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
                #endregion
              GUILayout.EndVertical();
              GUILayout.BeginVertical();
              #region MultiIcon
              GUILayout.Label("Item MultiIcon Icon:");
              if (qualityDatabase.Get(i).MultiIcon)
              {
                  selectedTextureMI = qualityDatabase.Get(i).MultiIcon.texture;

              }
              else
              {
                  selectedTextureMI = null;
              }

              if (GUILayout.Button(selectedTextureMI, GUILayout.Width(SPRITE_BUTTON_SIZE), GUILayout.Height(SPRITE_BUTTON_SIZE)))
              {
                  selectedIndex = -1;
                  selectedIndexCI = -1;
                  int controlorIDMI = EditorGUIUtility.GetControlID(FocusType.Passive);
                  EditorGUIUtility.ShowObjectPicker<Sprite>(null, true, null, controlorIDMI);
                  selectedIndexMI = i;
              }

              string commandNameMI = Event.current.commandName;
              if (commandNameMI == "ObjectSelectorUpdated")
              {
                  if (selectedIndexMI != -1)
                  {
                      qualityDatabase.Get(selectedIndexMI).MultiIcon = (Sprite)EditorGUIUtility.GetObjectPickerObject();
                      //     selectedIndex = -1;
                  }
                  Repaint();
              }

              #endregion
              GUILayout.EndVertical();
              GUILayout.BeginVertical();
              #region ComplitItem
              GUILayout.Label("Item ComplitItem Icon:");
              if (qualityDatabase.Get(i).CompleteIcon)
              {
                  selectedTextureCI = qualityDatabase.Get(i).CompleteIcon.texture;

              }
              else
              {
                  selectedTextureCI = null;
              }

              if (GUILayout.Button(selectedTextureCI, GUILayout.Width(SPRITE_BUTTON_SIZE), GUILayout.Height(SPRITE_BUTTON_SIZE)))
              {
                  selectedIndex = -1;
                  selectedIndexMI = -1;
                  int controlorIDCI = EditorGUIUtility.GetControlID(FocusType.Passive);
                  EditorGUIUtility.ShowObjectPicker<Sprite>(null, true, null, controlorIDCI);
                  selectedIndexCI = i;
              }

              string commandNameCI = Event.current.commandName;
              if (commandNameCI == "ObjectSelectorUpdated")
              {
                  if (selectedIndexCI != -1)
                  {
                      qualityDatabase.Get(selectedIndexCI).CompleteIcon = (Sprite)EditorGUIUtility.GetObjectPickerObject();
                      //     selectedIndex = -1;
                  }
                  Repaint();
              }

              #endregion
              GUILayout.EndVertical();
              GUILayout.EndHorizontal();

                
              //GUILayout.Label("Item Name:");
              //qualityDatabase.Get(i).NumberOfStack =Convert.ToInt32( GUILayout.TextField(qualityDatabase.Get(i).NumberOfStack) ); 


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
              //  GUILayout.EndHorizontal();
            }
        }

    }
}
