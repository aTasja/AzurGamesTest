using Player;
using UnityEngine;

namespace Finish
{
    public class FinishTrigger : MonoBehaviour
    {
        [SerializeField] private FinishUI _finishUI;

        private void OnTriggerEnter(Collider other)
        {
            if(other.GetComponent<PlayerPurse>())
                _finishUI.gameObject.SetActive(true);
        }

    }
}
