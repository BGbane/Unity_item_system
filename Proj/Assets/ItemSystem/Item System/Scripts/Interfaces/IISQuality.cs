using UnityEngine;
using System.Collections;

namespace BG.ItemSystem
{
    public interface IISQuality
    {
        string Name { get; set; }
        Sprite Icon { get; set; }
    }
}