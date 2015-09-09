using UnityEngine;
using System.Collections;


namespace BG.ItemSystem
{
    [System.Serializable]
    public class ISItem : IISItem
    {
        [SerializeField]
        bool _normal;
        [SerializeField]
        bool _stack ;
        [SerializeField]
        bool _partial; 
        [SerializeField]
        string _name;
        [SerializeField]
        Sprite _icon;
        [SerializeField]
        bool _ininventory;
        [SerializeField]
        bool _isdeleted;
        [SerializeField]
        string _multiname;
        [SerializeField]
        string _completename;
        [SerializeField]
        Sprite _multiIcon;
        [SerializeField]
        Sprite _completeIcon;
        [SerializeField]
        int _numberofstack;
        [SerializeField]
        int _curentnumberofstack;
        [SerializeField]
        int _multinumber;
        [SerializeField]
        int _curentmultinumber;



        public ISItem()
        {
            _normal = true;
            _stack = false;
            _partial = false;
            _name = "";
            _icon = new Sprite();
            _ininventory = false;
            _isdeleted = false;
            _multiname = "";
            _completename = "";
            _multiIcon = new Sprite();
            _completeIcon = new Sprite();
            _numberofstack = 0;
            _curentnumberofstack = 0;
            _multinumber = 0;
            _curentmultinumber = 0;
        }

        public ISItem(bool normal, bool stack, bool partial,string name, Sprite icon, bool ininventory, bool isdeleted,string multiname, string completename, 
            Sprite multiicon,Sprite completeicon, int numberofstack,int curentnumberofstack, int multinuber, int curentmultinumber)
        {
            _normal = normal;
            _stack = stack;
            _partial = partial;
            _name = name;
            _icon = icon;
            _ininventory = ininventory;
            _isdeleted = isdeleted;
            _multiname = multiname;
            _completename = completename;
            _multiIcon = multiicon;
            _completeIcon = completeicon;
            _numberofstack = numberofstack;
            _curentnumberofstack = curentnumberofstack;
            _multinumber = multinuber;
            _curentmultinumber = curentmultinumber;
        }



        public bool Normal
        {
            get { return _normal; }
            set { _normal = value; }
        }

        public bool Stack
        {
            get { return _stack; }
            set { _stack = value; }
        }

        public bool Partial
        {
            get { return _partial; }
            set { _partial = value; }
        }

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public Sprite Icon
        {
            get { return _icon; }
            set { _icon = value; }
        }

        public bool InInventory
        {
            get { return _ininventory; }
            set { _ininventory = value; }
        }

        public bool IsDeleted
        {
            get { return _isdeleted; }
            set { _isdeleted = value; }
        }

        public string MultyName
        {
            get { return _multiname; }
            set { _multiname = value; }
        }

        public string CompleteName
        {
            get { return _completename; }
            set { _completename = value; }
        }

        public Sprite MultiIcon
        {
            get { return _multiIcon; }
            set { _multiIcon = value; }
        }

        public Sprite CompleteIcon
        {
            get { return _completeIcon; }
            set { _completeIcon = value; }
        }

        public int NumberOfStack
        {
            get { return _numberofstack; }
            set { _numberofstack = value; }
        }

        public int CurentNumberOfStack
        {
            get { return _curentnumberofstack; }
            set { _curentnumberofstack = value; }
        }

        public int MultiNumber
        {
            get { return _multinumber; }
            set { _multinumber = value; }
        }

        public int CurentMultiNumber
        {
            get { return _curentmultinumber; }
            set { _curentmultinumber = value; }
        }
    }
}