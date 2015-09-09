using UnityEngine;
using System.Collections;

namespace BG.ItemSystem
{
    public interface IISItem 
    {   
        bool Normal { get; set; }
        bool Stack { get; set; }
        bool Partial { get; set; }
        string Name { get; set; }
        Sprite Icon { get; set; }
        bool InInventory { get; set; }
        bool IsDeleted { get; set; }
        string MultyName { get; set; }
        string CompleteName { get; set; }
        Sprite MultiIcon { get; set; }
        Sprite CompleteIcon { get; set; }
        int NumberOfStack { get; set; }
        int CurentNumberOfStack { get; set; }
        int MultiNumber { get; set; }
        int CurentMultiNumber { get; set; }

    }

}
