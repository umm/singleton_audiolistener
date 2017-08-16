using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityModule {

    public class SingletonAudioListener : MonoBehaviour {

        private void Start() {
            if (FindObjectOfType<AudioListener>() == default(AudioListener)) {
                this.gameObject.AddComponent<AudioListener>();
            }
        }

    }

}