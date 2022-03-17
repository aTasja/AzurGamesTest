using System.Collections;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Managers
{
    [RequireComponent(typeof(CoinsManager))]
    [RequireComponent(typeof(BasicUI))]
    public class GameManager:MonoBehaviour
    {
        private static BasicUI _basicUI;
        private static CoinsManager _coinsManager;
        private static Scene _scene;
        
        void Start()
        {
            _basicUI = GetComponent<BasicUI>();
            _coinsManager = GetComponent<CoinsManager>();
            _scene = SceneManager.GetActiveScene();
        }

        public static void UpdateCounter(int number) => _basicUI.UpdateCounter(number);

        public static void AddCoin() => _coinsManager.AddCoin();

        public static void Finish() => _basicUI.ShowFinishPanel();

        public static void LoadNextLevel() => SceneManager.LoadScene(_scene.name);
    }
}
