using UnityEngine;
using System.Collections;
using UnityEditor;


namespace BG.ItemSystem.Editor
{
    public partial class ISItemDatabaseEditor : EditorWindow
    {
        ISQualityDatabase qualityDatabase;
     //   ISQuality selectedItem;
        Texture2D selectedTexture;
        Texture2D selectedTextureMI;
        Texture2D selectedTextureCI;
        Vector2 _skrollPos;
        int selectedIndex = -1;
        int selectedIndexMI = -1;
        int selectedIndexCI = -1;

        const int SPRITE_BUTTON_SIZE = 75;

        const string DATABASE_FILE_NAME = @"bgQualityDatabase.asset";
        const string DATABASE_FOLDER_NAME = @"Database";
        const string DATABASE_FULL_PATH = @"Assets/" + DATABASE_FOLDER_NAME + "/" + DATABASE_FILE_NAME;

        [MenuItem("ItemSystem/Database/Item Editor %#i")]
        public static void Init()
        {

            ISItemDatabaseEditor window = EditorWindow.GetWindow<ISItemDatabaseEditor>("Quality Database");
            window.minSize = new Vector2(400, 300);
           // window.titleContent = "Quality Database";
            window.Show();
        }


        void OnEnable()
        {
            qualityDatabase = AssetDatabase.LoadAssetAtPath(DATABASE_FULL_PATH,typeof(ISQualityDatabase)) as ISQualityDatabase;
            if(qualityDatabase == null)
            {
                if (!AssetDatabase.IsValidFolder("Assets/" + DATABASE_FOLDER_NAME))
                {
                    AssetDatabase.CreateFolder("Assets", DATABASE_FOLDER_NAME);
                }

                    qualityDatabase = ScriptableObject.CreateInstance<ISQualityDatabase>();
                    AssetDatabase.CreateAsset(qualityDatabase, DATABASE_FULL_PATH);
                    AssetDatabase.SaveAssets();
                    AssetDatabase.Refresh();
            }
       //     selectedItem = new ISQuality();
        }

        void OnGUI()
        {
          // AddQuailtyToDatabase();
           ListView();
           GUILayout.BeginHorizontal("BOX", GUILayout.ExpandWidth(true));
           BottomBar();
           GUILayout.EndHorizontal();
        }

        void BottomBar()
        {
            GUILayout.Label("Items:"+qualityDatabase.Count);
            if(GUILayout.Button("Add"))
            {
                qualityDatabase.Add(new ISItem());
            }

        }

        //void AddQuailtyToDatabase()
        //{
        //    selectedItem.Name = EditorGUILayout.TextField("Name:", selectedItem.Name);
        //    if (selectedItem.Icon)
        //    {
        //        selectedTexture = selectedItem.Icon.texture;
        //    }
        //    else
        //    {
        //        selectedTexture = null;
        //    }

        //    if(GUILayout.Button(selectedTexture, GUILayout.Width(SPRITE_BUTTON_SIZE),GUILayout.Height(SPRITE_BUTTON_SIZE)))
        //    {
        //        int controlorID = EditorGUIUtility.GetControlID(FocusType.Passive);
        //        EditorGUIUtility.ShowObjectPicker<Sprite>(null, true, null, controlorID);
        //    }

        //    string commandName = Event.current.commandName;
        //    if (commandName == "ObjectSelectorUpdated")
        //    {
        //        selectedItem.Icon = (Sprite)EditorGUIUtility.GetObjectPickerObject();
        //        Repaint();
        //    }

        //   if( GUILayout.Button("Save"))
        //   {
              
        //       if (selectedItem == null)
        //           return;
        //       if (selectedItem.Name == "")
        //           return;

        //       qualityDatabase.Add(selectedItem);
          

        //       selectedItem = new ISQuality();
        //   }

        //}
    }
}