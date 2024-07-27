using UnityEngine;

namespace _1Content.Scripts
{
    public class PlayButtonEventInvoker: MonoBehaviour
    {
        public void Raise() => EventBus<PlayButtonPressed>.Raise(new PlayButtonPressed());
    }
}