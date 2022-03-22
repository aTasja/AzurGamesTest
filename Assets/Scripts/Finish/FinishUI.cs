using System;
using UnityEngine;

namespace Finish
{
    public class FinishUI : MonoBehaviour
    {
        public static event Action NextLevel;
        
        private void Start() => gameObject.SetActive(false);
        
        public void NextLevelButtonHandler() => NextLevel?.Invoke();
        
    }
}
