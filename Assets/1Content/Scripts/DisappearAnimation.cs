using DG.Tweening;
using UnityEngine;

namespace _1Content.Scripts
{
    public class DisappearAnimation: MonoBehaviour
    {
        public Ease easing = Ease.Linear;
        public float duration = 0.5f;

        private  Vector3 _endScale = new(0.01f, 0.01f, 0.01f);
        
        public void Play()
        {
            transform.DOScale(_endScale, duration).OnComplete(() => gameObject.SetActive(false));
        }
    }
}