using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Common
{
    public class GlobalController : MonoBehaviour
    {
        [SerializeField] private  HeaderController _HeaderController = null;
        [SerializeField] private  FooterController _FooterController = null;
        

        public static HeaderController HeaderController = null;
        public static FooterController FooterController = null;
        
        
        void Start()
        {
            HeaderController = _HeaderController;
            FooterController = _FooterController;
           
            _FooterController.OnAssetLoad();

            _HeaderController.Initialize();
            _FooterController.Initialize();

            

            Debug.Log("GlobalController");
        }

    }
}