using System;
using UnityEngine;

namespace Player
{
    public class PlayerPurse : MonoBehaviour
    {
        public static event Action<int> CoinCollected;
        
        private int _coinsQuantity;
        
        private void OnTriggerEnter(Collider other)
        {
            if (other.GetComponent<CollectibleCoin>()) {
                _coinsQuantity++;
                CoinCollected?.Invoke(_coinsQuantity);
            }
        }
    }
}