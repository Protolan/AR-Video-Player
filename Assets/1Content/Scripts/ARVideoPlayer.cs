using UnityEngine;
using UnityEngine.Video;

namespace _1Content.Scripts
{
    public class ARVideoPlayer: MonoBehaviour
    {
        [SerializeField] private VideoPlayer player;

        EventBinding<PlayButtonPressed> playerEventBinding;
        private void OnEnable() {    
            playerEventBinding = new EventBinding<PlayButtonPressed>(HandlePlayerEvent);
            EventBus<PlayButtonPressed>.Register(playerEventBinding);
            
        }
        private void OnDisable() {
            EventBus<PlayButtonPressed>.Deregister(playerEventBinding);
        }
        
        private void HandlePlayerEvent(PlayButtonPressed playerEvent) {
            player.Play();
        }
    }
}