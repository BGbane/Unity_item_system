using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using System.Linq; // for element at

namespace BG.ItemSystem 
{ 

public class ISQualityDatabase : ScriptableObject
    {
    [SerializeField]
    List<ISItem> database = new List<ISItem>();



    public void Add(ISItem item)
     {
         database.Add(item);
         EditorUtility.SetDirty(this);
     }

    public void Insert(int index, ISItem item)
    {
        database.Insert(index, item);
        EditorUtility.SetDirty(this);
    }

    public void Remove(ISItem item)
    {
        database.Remove(item);
        EditorUtility.SetDirty(this);
    }

    public void Remove(int index)
    {
        database.RemoveAt(index);
        EditorUtility.SetDirty(this);
    }


    public int Count
    {
        get { return database.Count; } 
    }


    public ISItem Get(int index)
    {
      return database.ElementAt(index);
    }


    public void Replace(int index, ISItem item)
    {
        database[index] = item;
        EditorUtility.SetDirty(this);

    }










    }
}