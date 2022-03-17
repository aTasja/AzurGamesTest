using UnityEngine;

namespace Managers
{
    public class CoinsManager : MonoBehaviour
    {
        private static int _coinsQuantity;
        
        private void Start() => _coinsQuantity = 0;

        public void AddCoin()
        {
            _coinsQuantity++;
            GameManager.UpdateCounter(_coinsQuantity);
        }
    }
}
