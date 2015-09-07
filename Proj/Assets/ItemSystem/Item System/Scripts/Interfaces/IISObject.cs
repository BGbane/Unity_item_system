using UnityEngine;
using System.Collections;


namespace BG.ItemSystem
{
    public interface IISObject
    {

        string ISName { get; set; }
        int ISValue { get; set; }
        Sprite ISIcon { get; set; }
        ISQuality ISQuality { get; set; }


    }
}